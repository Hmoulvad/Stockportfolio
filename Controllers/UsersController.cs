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
        private readonly StockportfolioDbContext context;
        public UsersController(StockportfolioDbContext context) 
        {
            this.context = context;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<User>> GetUsers() {
            return await context.Users.Include(u => u.UserStocks).ToListAsync();
        }

    }
}