using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockportfolio.Models;
using stockportfolio.Persistence;

namespace Stockportfolio.Controllers
{
    public class UsersController : Controller
    {
        public UsersController(StockportfolioDbContext context) 
        {
            this.context = context;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<User>> getUsers() {
            return await context.Users.Include(u => u.UserStocks).ToListAsync();
        }
        private readonly StockportfolioDbContext context;
        

    }
}