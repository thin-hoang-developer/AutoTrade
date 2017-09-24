using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoTrade.Entities
{
    [Table("Price")]
    public class CoinPrice
    {
        [Key]
        public int Id { get; set; }
        public double Bid { get; set; }
        public double Ask { get; set; }
        public string CoinId { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}