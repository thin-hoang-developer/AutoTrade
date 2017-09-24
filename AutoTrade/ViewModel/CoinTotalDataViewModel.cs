using AutoTrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoTrade.ViewModel
{
    public class CoinTotalDataViewModel
    {
        public IEnumerable<CoinInfo> CoinInfo { get; set; }

        public IEnumerable<CoinInfo> TrendingCoin { get; set; }

        public static CoinTotalDataViewModel Create(IEnumerable<CoinInfo> coinData)
        {
            return new CoinTotalDataViewModel()
            {
                CoinInfo = coinData.OrderBy(x => x.LatestBidHighRatio),
                TrendingCoin = coinData.Where(x =>  x.HighLowRatio > 20 && x.LatestBidHighRatio < -15 && x.Volume > 70).OrderBy(x => x.LatestBidHighRatio)
                //TrendingCoin = coinData.Where(x => x.LatestBidLowRatio <= 3 && x.HighLowRatio > 20)
            };
        }
    }
}