using AutoTrade.Entities;
using AutoTrade.Helper;
using AutoTrade.ViewModel;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AutoTrade.Controllers
{
    public class HomeController : Controller
    {
        public static CoinPrice GetCoinPrice(string url)
        {
            return ParseReponse(url).Result.ToObject<CoinPrice>();
        }

        public static IEnumerable<CoinData> GetCoinDataAsync(string url)
        {
            return ParseReponse(url).Result.ToObject<IEnumerable<CoinData>>();
        }

        public static IEnumerable<MarketHistory> GetMarketHistory(string url, string coinName)
        {
            return ParseReponse($"{url}{coinName}").Result.ToObject<IEnumerable<MarketHistory>>();
        }

        public static async Task<JToken> ParseReponse(string url)
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(url).ConfigureAwait(false))
                {
                    response.EnsureSuccessStatusCode();
                    var content = await response.Content.ReadAsStringAsync();
                    var token = JObject.Parse(content);
                    return token.SelectToken("result");
                }
            }
        }

        public ActionResult Index()
        {
            //var coinData = GetCoinDataAsync(Const.GETMARKETS);
            //var marketHistory = GetMarketHistory(Const.GETMARKETHISTORY, "BTC-NEO");
            //var sell = marketHistory.Where(x => x.OrderType.Equals("SELL")).OrderByDescending(x => x.TimeStamp);
            //var buy = marketHistory.Where(x => x.OrderType.Equals("BUY")).OrderByDescending(x => x.TimeStamp);
            IEnumerable<CoinInfo> result  = Enumerable.Empty<CoinInfo>();
            using (var context = new AutoTradeDbContext())
            {
                result = context.Database.SqlQuery<CoinInfo>("GetCoinInfo").ToList();
            }
            return View(CoinTotalDataViewModel.Create(result));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}