using Buxis.Sample.ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Buxis.Sample.Infrastructure
{
    public class BuxiDbContext : DbContext
    {
        public BuxiDbContext(DbContextOptions<BuxiDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }

    }
}
