using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockportfolio.Models
{
    public class UserStock : Stock
    {
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}