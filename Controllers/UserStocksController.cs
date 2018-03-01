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
    public class UsersStocksController : Controller
    {
        private readonly StockportfolioDbContext context;
        private readonly IMapper mapper;
        public UsersStocksController(StockportfolioDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/userstocks")]
        public async Task<IEnumerable<UserStockResource>> GetUsers()
        {
            var userstocks = await context.UserStocks.Include(s => s.Stock).ToListAsync();

            return mapper.Map<List<UserStock>, List<UserStockResource>>(userstocks);
        }
    }
}