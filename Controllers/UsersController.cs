using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockportfolio.Controllers.Resources;
using stockportfolio.Models;
using stockportfolio.Persistence;

namespace Stockportfolio.Controllers
{
    public class UsersController : Controller
    {
        private readonly StockportfolioDbContext context;
        private readonly IMapper mapper;
        public UsersController(StockportfolioDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/users")]
        public async Task<IEnumerable<UserResource>> GetUsers()
        {
            var users = await context.Users.Include(u => u.UserStocks).ToListAsync();

            return mapper.Map<List<User>, List<UserResource>>(users);
        }

    }
}