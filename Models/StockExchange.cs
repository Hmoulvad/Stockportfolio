using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace stockportfolio.Models

{
    public class StockExchange
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public string Symbol {get; set;}
        public Collection<Stock> Stocks {get; set;}
        public StockExchange() {
            Stocks = new Collection<Stock>();
        }

    }
}