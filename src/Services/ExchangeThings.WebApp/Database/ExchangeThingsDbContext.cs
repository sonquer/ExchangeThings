using ExchangeThings.WebApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace ExchangeThings.WebApp.Database
{
    public class ExchangeThingsDbContext : DbContext
    {
        public ExchangeThingsDbContext(DbContextOptions<ExchangeThingsDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<ExchangeItemEntity> ExchangeItemEntities { get; set; }
    }
}