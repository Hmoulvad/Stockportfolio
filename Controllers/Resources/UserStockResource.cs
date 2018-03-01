using System;

namespace stockportfolio.Controllers.Resources
{
    public class UserStockResource
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
    }
}