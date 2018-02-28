using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace stockportfolio.Models
{
    [Table("UserStock")]
    public class UserStock
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchasePrice { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Stock Stock { get; set; }
        public int StockId { get; set; }
    }
}