using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.Helper
{
    public static class Const
    {
        public static string APIKEY = "832f1ac1704646a5896936df924d1aa9";
        public static string APIKEYSECRET = "896bcbe7472f44a9b8ef0ef6bb8d460a";

        public static string BASEURL = "https://bittrex.com/api/v1.1/";
        public static string GETMARKETS = $"{BASEURL}public/getmarkets";
        public static string GETMARKETSUMARIES = $"{BASEURL}public/getmarketsummaries";
        public static string GETMARKETHISTORY = $"{BASEURL}public/getmarkethistory?market=";
        public static string GETTICKER = $"{BASEURL}public/getticker?market=";

        public enum OrderType
        {
            Buy = 0,
            Sell = 1
        }
    }

}
