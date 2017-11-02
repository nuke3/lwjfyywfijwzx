﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using Exchange.Kraken;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Exchange.KrakenTests
{
    public class FeesTests
    {
        public string apiAddress = "https://api.kraken.com/0/public/";

        [TestCase("DASHXBT", OperationCostCalculator.OPERATION_TYPE.maker, 125000, ExpectedResult = 0.0012)]
        [TestCase("EOSETH", OperationCostCalculator.OPERATION_TYPE.taker, 5100000, ExpectedResult = 0.0012)]
        [TestCase("BCHXBT", OperationCostCalculator.OPERATION_TYPE.taker, 0, ExpectedResult = 0.0026)]
        [TestCase("DASHEUR", OperationCostCalculator.OPERATION_TYPE.maker, 0, ExpectedResult = 0.0016)]
        public decimal TransactionFees(string currencyPair, OperationCostCalculator.OPERATION_TYPE operationType, decimal volume)
        {
            OperationCostCalculator calc = new OperationCostCalculator(apiAddress);

            decimal result = calc.CalculateTransactionFee(currencyPair, operationType, volume);
            return result;

        }

        //[TestCase("BTC", OperationCostCalculator.TRANSFER_DIR.incomming, ExpectedResult = 0)]
        //[TestCase("BTC", OperationCostCalculator.TRANSFER_DIR.outgoing, ExpectedResult = 0.00045)]
        //[TestCase("ETH", OperationCostCalculator.TRANSFER_DIR.incomming, ExpectedResult = 0)]
        //[TestCase("ETH", OperationCostCalculator.TRANSFER_DIR.outgoing, ExpectedResult = 0.00126)]
        //public decimal TransferFees(string currency, OperationCostCalculator.TRANSFER_DIR direction)
        //{
        //    OperationCostCalculator calc = new OperationCostCalculator(feesJson);

        //    decimal result = calc.CalculateTransferCost(currency, direction);
        //    return result;
        //}
    }
}
