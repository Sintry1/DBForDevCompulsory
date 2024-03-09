using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBMigrations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        private string ConnectionString = "DESKTOP-VAUPBM7";
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlServer($"Server={ConnectionString};Database=EFCoreMigrations;Trusted_Connection=True;TrustServerCertificate=true");

            return new DBContext(optionsBuilder.Options);
        }
    }
}