using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockportfolio.Models

{
    [Table("StockExchange")]
    public class StockExchange
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Symbol {get; set;}
        public ICollection<Stock> Stocks {get; set;}
        public StockExchange() {
            Stocks = new Collection<Stock>();
        }

    }
}