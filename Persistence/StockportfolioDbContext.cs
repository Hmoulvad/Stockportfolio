using Microsoft.EntityFrameworkCore;

namespace stockportfolio.Persistence
{
    public class StockportfolioDbContext : DbContext
    {
     public StockportfolioDbContext(DbContextOptions<StockportfolioDbContext> options)
     : base(options)
     {
         //Systenm  
     }   
    }
}