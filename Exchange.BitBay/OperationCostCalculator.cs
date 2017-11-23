﻿using Exchange.MarketUtils;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace Exchange.BitBay
{
    public class OperationCostCalculator : IOperationFeesCalculator
    {
        //public enum TRANSFER_DIR { incomming, outgoing };

        //public enum FEE_TYPE { absolute, fraction };

        //public enum OPERATION_TYPE { maker, taker };

        private BitbayFees _fees;
        private decimal _accountMonthlyVolume;

        public OperationCostCalculator(string feesJson, decimal accountMonthlyVolume)
        {
            _fees = JsonConvert.DeserializeObject<BitbayFees>(feesJson);
            _accountMonthlyVolume = accountMonthlyVolume;
        }

        /// <summary>
        /// Calculating cost of transfer operation
        /// </summary>
        /// <param name="currency"></param>
        /// <param name="inOut"></param>
        /// <returns>Transfer cost in the same currency as provided</returns>
        public decimal CalculateTransferCost(string currency, OperationTypes.TRANSFER_DIR direction, decimal transferAmount = -1)
        {
            //find correct fee
            var fee = _fees.transfer.SingleOrDefault(f => f.currency == currency);

            if (fee == null)
                throw new InvalidDataException($"Unable to find transfer fee");

            return CalculateTransferFee(fee, direction, transferAmount);
        }

        private decimal CalculateTransferFee(TransferFee fee, OperationTypes.TRANSFER_DIR direction, decimal transferAmount)
        {
            if (fee.feeType == OperationTypes.FEE_TYPE.absolute.ToString())
            {
                if (direction == OperationTypes.TRANSFER_DIR.incomming)
                    return fee.incoming;
                else if (direction == OperationTypes.TRANSFER_DIR.outgoing)
                    return fee.outgoing;
            }
            else if (fee.feeType == OperationTypes.FEE_TYPE.fraction.ToString())
            {
                if (transferAmount <= 0)
                    throw new InvalidDataException("To calculate fraction fee you need to provide transfer amount");

                if (direction == OperationTypes.TRANSFER_DIR.incomming)
                    return fee.incoming * transferAmount;
                else if (direction == OperationTypes.TRANSFER_DIR.outgoing)
                    return fee.outgoing * transferAmount;
            }

            throw new InvalidDataException("Fee for specified case does not exist");
        }

        /// <summary>
        /// Calculating cost of transaction
        /// </summary>
        /// <param name="operationType"></param>
        /// <param name="volume">In this case it is monthly volume EUR</param>
        /// <returns>Fee in currency. To calculate final one take your operaiton volume and multiply by returned fee</returns>
        public decimal CalculateTransactionFee(string currencyPair, OperationTypes.OPERATION_TYPE operationType)
        {
            TransactionFee fee;

            if (_accountMonthlyVolume <= 0) //take highest possible
                fee = _fees.transaction.OrderBy(f => f.treshold).First();
            else
                fee = _fees.transaction.Where(f => f.treshold > _accountMonthlyVolume).OrderBy(f => f.treshold).First();

            if (fee == null)
                throw new InvalidDataException($"Fee not defined for operation type {operationType.ToString()} monthly volume {_accountMonthlyVolume.ToString()}");

            if (operationType == OperationTypes.OPERATION_TYPE.maker)
                return fee.maker;
            else if (operationType == OperationTypes.OPERATION_TYPE.taker)
                return fee.taker;
            else
                throw new InvalidDataException($"Incorrect operation type");
        }
    }
}