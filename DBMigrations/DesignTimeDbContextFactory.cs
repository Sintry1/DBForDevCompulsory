using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBMigrations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {
        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\16.0.1.1000.6;Database=EFCoreMigrations;Trusted_Connection=True;");

            return new DBContext(optionsBuilder.Options);
        }
    }
}