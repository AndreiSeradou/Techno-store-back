using Microsoft.EntityFrameworkCore;
using Techno_store_back.DataAccessLayer.Entities;

namespace Techno_store_back.DataAccessLayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();     
        }
        public DbSet<Laptop> Laptops { get; set; }
    }
}
