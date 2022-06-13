using Microsoft.EntityFrameworkCore;
using Techno_store_back.DAL.Entities;

namespace Techno_store_back.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
    }
}
