using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using stockportfolio.Models;
using stockportfolio.Persistence;

namespace Stockportfolio.Persistence
{
    public class DbInitializer
    {
        public static void InitializeStockExchange(StockportfolioDbContext context)
        {
            if (context.StockExchanges.Any())
                return;
            
            using (var webClient = new System.Net.WebClient()) 
            {
            string json = webClient.DownloadString("https://api.stockdio.com/data/financial/prices/v1/getStockExchangesInfo?app-key=E617E051095142DF8B044DB452EA9799");
            JObject jsonObject = JObject.Parse(json);

            IList<JToken> results = jsonObject["data"]["exchanges"]["values"].Children().ToList();
            // serialize JSON results into .NET objects
            IList<StockExchange> exchanges = new List<StockExchange>();
            
            foreach (JToken result in results)
            {
                if (result[0] != null && result[1] != null )
                {
                    if ((string)result[0] != "crypto" && (string)result[0] != "bonds" && (string)result[0] != "delete" && (string)result[0] != "commodities") 
                    {
                    context.StockExchanges.Add(new StockExchange(){Name=(string)result[1],Symbol=(string)result[0]});
                    exchanges.Add(new StockExchange(){Name=(string)result[1],Symbol=(string)result[0]});
                    }
                }

            }
            
            context.SaveChanges();
            }
        }
        public static void InitializeStocks(StockportfolioDbContext context)
        {
            if (context.StockExchanges.Any())
                return;
            
            using (var webClient = new System.Net.WebClient()) 
            {
            string json = webClient.DownloadString("https://api.stockdio.com/data/financial/prices/v1/getStockExchangesInfo?app-key=E617E051095142DF8B044DB452EA9799");
            JObject jsonObject = JObject.Parse(json);

            IList<JToken> results = jsonObject["data"]["exchanges"]["values"].Children().ToList();
            // serialize JSON results into .NET objects
            IList<StockExchange> exchanges = new List<StockExchange>();
            
            foreach (JToken result in results)
            {
                if (result[0] != null && result[1] != null )
                {
                    if ((string)result[0] != "crypto" && (string)result[0] != "bonds" && (string)result[0] != "delete" && (string)result[0] != "commodities") 
                    {
                    context.StockExchanges.Add(new StockExchange(){Name=(string)result[1],Symbol=(string)result[0]});
                    exchanges.Add(new StockExchange(){Name=(string)result[1],Symbol=(string)result[0]});
                    }
                }

            }
            
            context.SaveChanges();
            }
        }
    }
}