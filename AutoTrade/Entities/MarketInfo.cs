using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.Entities
{
    public class MarketInfo
    {
        public string MarketCurrency { get; set; }
        public string BaseCurrency { get; set; }
        public string MarketCurrencyLong { get; set; }
        public string MinTradeSize { get; set; }
        public string MarketName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
    }
}