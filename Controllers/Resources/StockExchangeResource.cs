using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace stockportfolio.Controllers.Resources
{
    public class StockExchangeResource
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Symbol {get; set;}
        public ICollection<StockResource> Stocks {get; set;}
        public StockExchangeResource() {
            Stocks = new Collection<StockResource>();
        }

    }
}