﻿using Exchange.MarketUtils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exchange.Poloniex
{
    public static class CurrenciesNamesMap
    {
        public static Dictionary<string, string> MapCrypto
        {           
            get
            {
                return new Dictionary<string, string>()
                {
                    {Currencies._1CRedit, "1CR"},
                    {Currencies.ArtByte, "ABY"},
                    {Currencies.AsiaCoin, "AC"},
                    {Currencies.AltcoinHerald, "ACH"},
                    {Currencies.Aiden, "ADN"},
                    {Currencies.AEONCoin, "AEON"},
                    {Currencies.Aerocoin, "AERO"},
                    {Currencies.AIRcoin, "AIR"},
                    {Currencies.SynereoAMP, "AMP"},
                    {Currencies.AphroditeCoin, "APH"},
                    {Currencies.ARCHcoin, "ARCH"},
                    {Currencies.Ardor, "ARDR"},
                    {Currencies.Auroracoin, "AUR"},
                    {Currencies.Axis, "AXIS"},
                    {Currencies.Snowballs, "BALLS"},
                    {Currencies.BankCoin, "BANK"},
                    {Currencies.BitBlock, "BBL"},
                    {Currencies.Boolberry, "BBR"},
                    {Currencies.BTCtalkcoin, "BCC"},
                    {Currencies.BitcoinCash, "BCH"},
                    {Currencies.Bytecoin, "BCN"},
                    {Currencies.BitCrystals, "BCY"},
                    {Currencies.BlackDragonCoin, "BDC"},
                    {Currencies.Badgercoin, "BDG"},
                    {Currencies.Bela, "BELA"},
                    {Currencies.BitCNY, "BITCNY"},
                    {Currencies.Bitstar, "BITS"},
                    {Currencies.BitUSD, "BITUSD"},
                    {Currencies.BlackCoin, "BLK"},
                    {Currencies.Blocknet, "BLOCK"},
                    {Currencies.BlueCoin, "BLU"},
                    {Currencies.BonusCoin, "BNS"},
                    {Currencies.Bones, "BONES"},
                    {Currencies.BoostCoin, "BOST"},
                    {Currencies.Bitcoin, "BTC"},
                    {Currencies.BitcoinDark, "BTCD"},
                    {Currencies.Bitcoin_sCrypt, "BTCS"},
                    {Currencies.Bitmark, "BTM"},
                    {Currencies.BitShares, "BTS"},
                    {Currencies.BurnerCoin, "BURN"},
                    {Currencies.Burst, "BURST"},
                    {Currencies.Coin20, "C2"},
                    {Currencies.CACHeCoin, "CACH"},
                    {Currencies.CaiShen, "CAI"},
                    {Currencies.ColbertCoin, "CC"},
                    {Currencies.Cannacoin, "CCN"},
                    {Currencies.CryptographicAnomaly, "CGA"},
                    {Currencies.Chancecoin, "CHA"},
                    {Currencies.CinniCoin, "CINNI"},
                    {Currencies.CLAMS, "CLAM"},
                    {Currencies.ConcealCoin, "CNL"},
                    {Currencies.Coinomat1, "CNMT"},
                    {Currencies.C_Note, "CNOTE"},
                    {Currencies.CommunityCoin, "COMM"},
                    {Currencies.Coino, "CON"},
                    {Currencies.CorgiCoin, "CORG"},
                    {Currencies.CryptCoin, "CRYPT"},
                    {Currencies.Curecoin, "CURE"},
                    {Currencies.Civic, "CVC"},
                    {Currencies.ConspiracyCoin, "CYC"},
                    {Currencies.TheDAO, "DAO"},
                    {Currencies.Dash, "DASH"},
                    {Currencies.Decred, "DCR"},
                    {Currencies.DigiByte, "DGB"},
                    {Currencies.NeoDICE, "DICE"},
                    {Currencies.Diem, "DIEM"},
                    {Currencies.Dimecoin, "DIME"},
                    {Currencies.DistroCoin, "DIS"},
                    {Currencies.BitSharesDNS, "DNS"},
                    {Currencies.Dogecoin, "DOGE"},
                    {Currencies.DarkCash, "DRKC"},
                    {Currencies.Dreamcoin, "DRM"},
                    {Currencies.Dashcoin, "DSH"},
                    {Currencies.DvoraKoin, "DVK"},
                    {Currencies.EarthCoin, "EAC"},
                    {Currencies.EBTcoin, "EBT"},
                    {Currencies.ECCoin, "ECC"},
                    {Currencies.ElectronicGulden, "EFL"},
                    {Currencies.Einsteinium, "EMC2"},
                    {Currencies.EmotiCoin, "EMO"},
                    {Currencies.Entropycoin, "ENC"},
                    {Currencies.EthereumClassic, "ETC"},
                    {Currencies.Ethereum, "ETH"},
                    {Currencies.eToken, "eTOK"},
                    {Currencies.Execoin, "EXE"},
                    {Currencies.Expanse, "EXP"},
                    {Currencies.Faircoin, "FAC"},
                    {Currencies.Fantomcoin, "FCN"},
                    {Currencies.Factom, "FCT"},
                    {Currencies.Fibrecoin, "FIBRE"},
                    {Currencies.FlappyCoin, "FLAP"},
                    {Currencies.FoldingCoin, "FLDC"},
                    {Currencies.Florincoin, "FLO"},
                    {Currencies.FlutterCoin, "FLT"},
                    {Currencies.FoxCoin, "FOX"},
                    {Currencies.Fractalcoin, "FRAC"},
                    {Currencies.Franko, "FRK"},
                    {Currencies.FairQuark, "FRQ"},
                    {Currencies.FVZCoin, "FVZ"},
                    {Currencies.Frozen, "FZ"},
                    {Currencies.Fuzon, "FZN"},
                    {Currencies.GameCredits, "GAME"},
                    {Currencies.Gapcoin, "GAP"},
                    {Currencies.Gas, "GAS"},
                    {Currencies.GlobalDenomination, "GDN"},
                    {Currencies.GetGems, "GEMZ"},
                    {Currencies.GeoCoin, "GEO"},
                    {Currencies.Giarcoin, "GIAR"},
                    {Currencies.Globe, "GLB"},
                    {Currencies.GameleagueCoin, "GML"},
                    {Currencies.Gnosis, "GNO"},
                    {Currencies.GenesisCoin, "GNS"},
                    {Currencies.Golem, "GNT"},
                    {Currencies.GoldEagles, "GOLD"},
                    {Currencies.GROUPCoin, "GPC"},
                    {Currencies.GPUCoin, "GPUC"},
                    {Currencies.GridcoinResearch, "GRC"},
                    {Currencies.Gridcoin, "GRCX"},
                    {Currencies.Groestlcoin, "GRS"},
                    {Currencies.Guerillacoin, "GUE"},
                    {Currencies.H2OCoin, "H2O"},
                    {Currencies.Hirocoin, "HIRO"},
                    {Currencies.Hotcoin, "HOT"},
                    {Currencies.Huntercoin, "HUC"},
                    {Currencies.BIGcoin, "HUGE"},
                    {Currencies.Heavycoin, "HVC"},
                    {Currencies.HyperStake, "HYP"},
                    {Currencies.Horizon, "HZ"},
                    {Currencies.Infinitecoin, "IFC"},
                    {Currencies.CoinoIndex, "INDEX"},
                    {Currencies.IODigitalCurrency, "IOC"},
                    {Currencies.InformationCoin, "ITC"},
                    {Currencies.iXcoin, "IXC"},
                    {Currencies.jl777hodl, "JLH"},
                    {Currencies.JackpotCoin, "JPC"},
                    {Currencies.JuggaloCoin, "JUG"},
                    {Currencies.KlondikeCoin, "KDC"},
                    {Currencies.KeyCoin, "KEY"},
                    {Currencies.LBRYCredits, "LBC"},
                    {Currencies.Limecoin, "LC"},
                    {Currencies.LimecoinLite, "LCL"},
                    {Currencies.Leafcoin, "LEAF"},
                    {Currencies.Logicoin, "LGC"},
                    {Currencies.LeagueCoin, "LOL"},
                    {Currencies.LOVEcoin, "LOVE"},
                    {Currencies.LIQUID, "LQD"},
                    {Currencies.Lisk, "LSK"},
                    {Currencies.LTBCoin, "LTBC"},
                    {Currencies.Litecoin, "LTC"},
                    {Currencies.LiteCoinX, "LTCX"},
                    {Currencies.MaidSafeCoin, "MAID"},
                    {Currencies.MastiffCoin, "MAST"},
                    {Currencies.MaxCoin, "MAX"},
                    {Currencies.MonetaVerde, "MCN"},
                    {Currencies.Megacoin, "MEC"},
                    {Currencies.CryptoMETH, "METH"},
                    {Currencies.MillenniumCoin, "MIL"},
                    {Currencies.Minerals, "MIN"},
                    {Currencies.Mintcoin, "MINT"},
                    {Currencies.MemoryCoin, "MMC"},
                    {Currencies.MMNXT, "MMNXT"},
                    {Currencies.Maieuticoin, "MMXIV"},
                    {Currencies.Moneta, "MNTA"},
                    {Currencies.Monocle, "MON"},
                    {Currencies.microCoin, "MRC"},
                    {Currencies.Marscoin, "MRS"},
                    {Currencies.Metiscoin, "MTS"},
                    {Currencies.Muniti, "MUN"},
                    {Currencies.Myriadcoin, "MYR"},
                    {Currencies.MazaCoin, "MZC"},
                    {Currencies.N5coin, "N5X"},
                    {Currencies.NAS, "NAS"},
                    {Currencies.Nautiluscoin, "NAUT"},
                    {Currencies.NAVCoin, "NAV"},
                    {Currencies.NuBits, "NBT"},
                    {Currencies.Neoscoin, "NEOS"},
                    {Currencies.Nanolite, "NL"},
                    {Currencies.Namecoin, "NMC"},
                    {Currencies.NobleCoin, "NOBL"},
                    {Currencies.DNotes, "NOTE"},
                    {Currencies.NobleNXT, "NOXT"},
                    {Currencies.NoirShares, "NRS"},
                    {Currencies.NuShares, "NSR"},
                    {Currencies.NTX, "NTX"},
                    {Currencies.Nexium, "NXC"},
                    {Currencies.NXT, "NXT"},
                    {Currencies.NXTInspect, "NXTI"},
                    {Currencies.OmiseGO, "OMG"},
                    {Currencies.Omni, "OMNI"},
                    {Currencies.Opal, "OPAL"},
                    {Currencies.PandaCoin, "PAND"},
                    {Currencies.PascalCoin, "PASC"},
                    {Currencies.Pawncoin, "PAWN"},
                    {Currencies.NewPiggycoin, "PIGGY"},
                    {Currencies.Pinkcoin, "PINK"},
                    {Currencies.ParallaxCoin, "PLX"},
                    {Currencies.Premine, "PMC"},
                    {Currencies.PotCoin, "POT"},
                    {Currencies.Peercoin, "PPC"},
                    {Currencies.ProsperCoin, "PRC"},
                    {Currencies.Particle, "PRT"},
                    {Currencies.BitSharesPTS, "PTS"},
                    {Currencies.QubitCoin, "Q2C"},
                    {Currencies.Qibuck, "QBK"},
                    {Currencies.QuazarCoin, "QCN"},
                    {Currencies.Qora, "QORA"},
                    {Currencies.Quatloo, "QTL"},
                    {Currencies.Radium, "RADS"},
                    {Currencies.Rubycoin, "RBY"},
                    {Currencies.Reddcoin, "RDD"},
                    {Currencies.Augur, "REP"},
                    {Currencies.Riecoin, "RIC"},
                    {Currencies.Razor, "RZR"},
                    {Currencies.SteemDollars, "SBD"},
                    {Currencies.Siacoin, "SC"},
                    {Currencies.Shadow, "SDC"},
                    {Currencies.ShibeCoin, "SHIBE"},
                    {Currencies.ShopX, "SHOPX"},
                    {Currencies.Silkcoin, "SILK"},
                    {Currencies.StorjcoinX, "SJCX"},
                    {Currencies.SolarCoin, "SLR"},
                    {Currencies.SmartCoin, "SMC"},
                    {Currencies.SocialCoin, "SOC"},
                    {Currencies.Spaincoin, "SPA"},
                    {Currencies.Squallcoin, "SQL"},
                    {Currencies.SourceCoin, "SRCC"},
                    {Currencies.Surge, "SRG"},
                    {Currencies.Sonic, "SSD"},
                    {Currencies.STEEM, "STEEM"},
                    {Currencies.Storj, "STORJ"},
                    {Currencies.Stellar, "STR"},
                    {Currencies.Stratis, "STRAT"},
                    {Currencies.SummerCoin, "SUM"},
                    {Currencies.Suncoin, "SUN"},
                    {Currencies.SWARM, "SWARM"},
                    {Currencies.Sexcoin, "SXC"},
                    {Currencies.Sync, "SYNC"},
                    {Currencies.Syscoin, "SYS"},
                    {Currencies.Talkcoin, "TAC"},
                    {Currencies.TorCoin, "TOR"},
                    {Currencies.TrustPlus, "TRUST"},
                    {Currencies.Twecoin, "TWE"},
                    {Currencies.Unitus, "UIS"},
                    {Currencies.Umbrella_LTC, "ULTC"},
                    {Currencies.SuperNET, "UNITY"},
                    {Currencies.Uro, "URO"},
                    {Currencies.USDE, "USDE"},
                    {Currencies.TetherUSD, "USDT"},
                    {Currencies.UltraCoin, "UTC"},
                    {Currencies.UtilityCoin, "UTIL"},
                    {Currencies.UniversityCoin, "UVC"},
                    {Currencies.Viacoin, "VIA"},
                    {Currencies.VootCoin, "VOOT"},
                    {Currencies.Voxels, "VOX"},
                    {Currencies.VeriCoin, "VRC"},
                    {Currencies.Vertcoin, "VTC"},
                    {Currencies.WhiteCoin, "WC"},
                    {Currencies.Worldcoin, "WDC"},
                    {Currencies.Wikicoin, "WIKI"},
                    {Currencies.InsanityCoin, "WOLF"},
                    {Currencies.X13Coin, "X13"},
                    {Currencies.SapienceAIFX, "XAI"},
                    {Currencies.APICoin, "XAP"},
                    {Currencies.BitcoinPlus, "XBC"},
                    {Currencies.XCurrency, "XC"},
                    {Currencies.ClearingHouse, "XCH"},
                    {Currencies.Cryptonite, "XCN"},
                    {Currencies.Counterparty, "XCP"},
                    {Currencies.Crypti, "XCR"},
                    {Currencies.DigitalNote, "XDN"},
                    {Currencies.Dogeparty, "XDP"},
                    {Currencies.NEM, "XEM"},
                    {Currencies.Honorcoin, "XHC"},
                    {Currencies.Libertycoin, "XLB"},
                    {Currencies.Magi, "XMG"},
                    {Currencies.Monero, "XMR"},
                    {Currencies.Pebblecoin, "XPB"},
                    {Currencies.Primecoin, "XPM"},
                    {Currencies.Ripple, "XRP"},
                    {Currencies.StabilityShares, "XSI"},
                    {Currencies.StealthCoin, "XST"},
                    {Currencies.SiliconValleyCoin, "XSV"},
                    {Currencies.CoinoUSD, "XUSD"},
                    {Currencies.Vcash, "XVC"},
                    {Currencies.CREDS, "XXC"},
                    {Currencies.YACCoin, "YACC"},
                    {Currencies.Yangcoin, "YANG"},
                    {Currencies.YellowCoin, "YC"},
                    {Currencies.Yincoin, "YIN"},
                    {Currencies.Zcash, "ZEC"},
                    {Currencies._0x, "ZRX"}
                };
            }
        }

        public static Dictionary<string, string> MapFiat
        {
            get
            {
                return new Dictionary<string, string>();
            }
        }

        //public static Dictionary<string, string> MapCrypto {get {return _mapCrypto;} }
        //public static Dictionary<string, string> MapFiat { get { return _mapFiat; } }

        public static string MapNamesToPair(string currency1, string currency2)
        {
            string symbol1 = MapName(currency1);
            string symbol2 = MapName(currency2);
            return string.Concat(symbol1, "_", symbol2);
        }

        public static Tuple<string,string> PairToCurrenciesNames(string pair)
        {
            List<string> symbols = pair.Split('_').ToList();

            if (symbols.Count != 2)
                return null;//throw new Exception($"invalid pair {pair}");

            string currency1 = SymbolToName(symbols[0]);
            string currency2 = SymbolToName(symbols[1]);

            if (currency1 != null && currency2 != null)
                return new Tuple<string, string>(currency1, currency2);
            else
                return null;
        }

        public static string SymbolToName(string symbol)
        {           
            if (MapCrypto.Any(e => e.Value == symbol))
                return MapCrypto.First(e => e.Value == symbol).Key;
            else
                return null;                
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Kraken currency symbol</returns>
        public static string MapName(string name)
        {
            string symbol = string.Empty;

            if (MapCrypto.TryGetValue(name, out symbol))
                return symbol;
            else if (MapFiat.TryGetValue(name, out symbol))
                return symbol;
            else
                throw new System.Exception($"Currency symbol not defined for name {name}");
        }



        public static Dictionary<string, string> All()
        {
            var all = new Dictionary<string, string>();

            foreach (KeyValuePair<string, string> pair in MapCrypto)
                all.Add(pair.Key, pair.Value);

            foreach (KeyValuePair<string, string> pair in MapFiat)
                all.Add(pair.Key, pair.Value);

            return all;
        }
    }
}