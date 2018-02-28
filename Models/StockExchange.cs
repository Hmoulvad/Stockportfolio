using System.Collections.Generic;

namespace stockportfolio.Models

{
    public class StockExchange
    {
        public int StockExchangeID {get; set;}
        public string Name {get; set;}
        public string Symbol {get; set;}
        public static List<Stock> Stocks {get; set;}
    }
}