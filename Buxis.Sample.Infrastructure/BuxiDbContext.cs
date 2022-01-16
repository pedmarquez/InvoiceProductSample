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
        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<ProductAttribute> ProductAttribute { get; set; }
    }
}
