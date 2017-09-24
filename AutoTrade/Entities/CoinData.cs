using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutoTrade.Entities
{
    public class CoinData
    {
        [Key]
        public int Id { get; set; }
        [Column("Name", TypeName="varchar")]
        public string MarketCurrency { get; set; }
        public string BaseCurrency { get; set; }
        [Column("FullName", TypeName = "varchar")]
        public string MarketCurrencyLong { get; set; }
        public string BaseCurrencyLong { get; set; }
        public double MinTradeSize { get; set; }
        public string MarketName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public string Notice { get; set; }
        public string IsSponsored { get; set; }
        public string LogoUrl { get; set; }
    }
}