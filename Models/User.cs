using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace stockportfolio.Models
{
    public class User
    {
        public int Id {get; set;}
        [Required]
        public string FirstName{get; set;}
        [Required]
        public string LastName {get; set;}
        [Required]
        public string Email {get; set;}

        public ICollection<UserStock> UserStocks { get; set; }

        public User()
        {
            UserStocks = new Collection<UserStock>();
        }
    }
}