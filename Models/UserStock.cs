using System;

namespace stockportfolio.Models
{
    public class UserStock : Stock
    {
        public int Amount {get; set;}
        public DateTime PurchaseDate {get; set;}
        public double PurchasePrice {get; set;}
    }
}