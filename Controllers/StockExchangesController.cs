using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockportfolio.Controllers.Resources;
using stockportfolio.Models;
using stockportfolio.Persistence;

namespace stockportfolio.Controllers
{
    public class StockExchangesController : Controller
    {
        private readonly StockportfolioDbContext context;

        private readonly IMapper mapper;

        public StockExchangesController(StockportfolioDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }
        [HttpGet("/api/stockexchanges")]

        public async Task<IEnumerable<StockExchangeResource>> GetStockExchanges() 
        {
            var stockexchanges = await context.StockExchanges.Include(s => s.Stocks).ToListAsync();

            return mapper.Map<List<StockExchange>, List<StockExchangeResource>>(stockexchanges);
        }
    }
}