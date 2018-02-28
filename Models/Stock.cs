using System.ComponentModel.DataAnnotations.Schema;

namespace stockportfolio.Models
{
    [Table("Stock")]
    public class Stock
    {

        public int Id {get; set;}
        public string Name {get; set;}
        public string Currency {get; set;}
        public string Symbol {get; set;}
        public StockExchange StockExchange { get; set; }
        public int StockExchangeID { get; set; }
    }
}   