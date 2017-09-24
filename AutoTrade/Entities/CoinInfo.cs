using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutoTrade.Entities
{
    public class CoinInfo
    {
        [Key]
        public string CoinId { get; set; }
        [NotMapped]
        public decimal? LatestAsk { get; set; }
        public decimal? LatestBid { get; set; }
        //[NotMapped]
        //public decimal? Prev5MAsk { get; set; }
        //public decimal? Prev5MBid { get; set; }
        //[NotMapped]
        //public decimal? Prev10MAsk { get; set; }
        //public decimal? Prev10MBid { get; set; }
        //[NotMapped]
        //public decimal? Prev30MAsk { get; set; }
        //public decimal? Prev30MBid { get; set; }
        //[NotMapped]
        //public decimal? Prev1HAsk { get; set; }
        //public decimal? Prev1HBid { get; set; }
        //[NotMapped]
        //public decimal? Prev2HAsk { get; set; }
        //public decimal? Prev2HBid { get; set; }
        //[NotMapped]
        //public decimal? Prev3HAsk { get; set; }
        //public decimal? Prev3HBid { get; set; }
        //[NotMapped]
        //public decimal? Prev6HAsk { get; set; }
        //public decimal? Prev6HBid { get; set; }
        //[NotMapped]
        //public decimal? Prev24HAsk { get; set; }
        //public decimal? Prev24HBid { get; set; }
        public decimal? Volume { get; set; }
        public decimal? PrevBaseVolume { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }

        [NotMapped]
        public decimal VolumeChangePercent
        {
            get
            {
                return CalculatePercent(Volume, PrevBaseVolume);
            }
        }


        //[NotMapped]
        //public decimal Prev5MAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev5MAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev5MBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev5MBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev10MAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev10MAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev10MBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev10MBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev30MAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev30MAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev30MBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev30MBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev1HAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev1HAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev1HBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev1HBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev2HAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev2HAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev2HBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev2HBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev3HAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev3HAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev3HBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev3HBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev6HAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev6HAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev6HBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev6HBid);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev24HAskPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestAsk, Prev24HAsk);
        //    }
        //}
        //[NotMapped]
        //public decimal Prev24HBidPercent
        //{
        //    get
        //    {
        //        return CalculatePercent(LatestBid, Prev24HBid);
        //    }
        //}

        [NotMapped]
        public DateTime LatestTime { get; set; }

        //public int OpenBuyOrders { get; set; }
        //public int OpenSellOrders { get; set; }

        //[NotMapped]
        //public int SellBuyRatio
        //{
        //    get
        //    {
        //        return OpenBuyOrders - OpenSellOrders;
        //    }
        //}

        [NotMapped]
        public decimal HighLowRatio
        {
            get
            {
                return CalculatePercent(High, Low);
            }
        }

        [NotMapped]
        public decimal LatestBidHighRatio
        {
            get
            {
                return CalculatePercent(LatestBid, High);
            }
        }

        [NotMapped]
        public decimal LatestBidLowRatio
        {
            get
            {
                return CalculatePercent(LatestBid, Low);
            }
        }
        

        public decimal CalculatePercent(decimal? a, decimal? b)
        {
            return decimal.Round((a - b) / b * 100 ?? 0, 2, MidpointRounding.AwayFromZero);
        }
    }
}