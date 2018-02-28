using Microsoft.EntityFrameworkCore;
using stockportfolio.Models;

namespace stockportfolio.Persistence
{
    public class StockportfolioDbContext : DbContext
    {
     public StockportfolioDbContext(DbContextOptions<StockportfolioDbContext> options)
     : base(options)
     {
     }

     public DbSet<User> Users { get; set; }
    }
}