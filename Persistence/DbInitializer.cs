using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            // Hvis databasen er fyldt, returner metoden.
            if (context.StockExchanges.Any())
            {
                return;
            }
            
            using (var webClient = new System.Net.WebClient()) 
            {
            // Gem JSON reply som string
            string json = webClient.DownloadString("https://api.stockdio.com/data/financial/prices/v1/getStockExchangesInfo?app-key=E617E051095142DF8B044DB452EA9799");
            // Parse string til JObject
            JObject jsonObject = JObject.Parse(json);
            // Filtrer relevant data fra JSON fil og angiv som List af JTokens
            IList<JToken> results = jsonObject["data"]["exchanges"]["values"].Children().ToList();
            // Iterer igennem alle JTokens
            foreach (JToken result in results)
            {
                // Forhindre nullpointer exception ved start og slut af JToken
                if (result[0] != null && result[1] != null )
                {
                    // Filtrer Crypto, Bonds, Delete og Commodities fra.
                    if ((string)result[0] != "crypto" && (string)result[0] != "bonds" && (string)result[0] != "delete" && (string)result[0] != "commodities") 
                    {
                    // Opret objekter udfra JSON og gem i context (Database)
                    context.StockExchanges.Add(new StockExchange(){Name=(string)result[1],Symbol=(string)result[0]});
                    }
                }

            }
            // Gem ændringer i databasen
            context.SaveChanges();
            }
        }
        public static void InitializeStocks(StockportfolioDbContext context)
        {
            // TODO: Opret Stocks fra API.  
        }
    }
}