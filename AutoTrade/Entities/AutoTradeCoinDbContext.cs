using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoTrade.Entities
{
    public class AutoTradeDbContext : DbContext
    {
        public AutoTradeDbContext() : base("Name=DefaultConnection")
        {
        }

        public DbSet<CoinData> Coins { get; set; }
        public DbSet<CoinPrice> Prices { get; set; }
        public DbSet<CoinInfo> CoinInfo { get; set; }
    }
}