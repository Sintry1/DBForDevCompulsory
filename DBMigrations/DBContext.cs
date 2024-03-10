using DBMigrations.Models;
using Microsoft.EntityFrameworkCore;

namespace DBMigrations
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options) { }

        public DbSet<Products> Products { get; set; }
        public DbSet<ProductRatings> ProductRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.Property(e => e.Price).HasPrecision(18, 2);
            });
        }
    }
}
