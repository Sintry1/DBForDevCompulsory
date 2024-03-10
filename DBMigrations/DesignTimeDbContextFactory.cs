using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBMigrations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {

        // Change this to the name of your local MSSQL server.
        private string ConnectionString = "DESKTOP-VAUPBM7";

        // Change this to whatever you want the name of your database to be.
        private string DatabaseName = "EFCoreMigrations";

        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlServer($"Server={ConnectionString};Database={DatabaseName};Trusted_Connection=True;TrustServerCertificate=true");

            return new DBContext(optionsBuilder.Options);
        }
    }
}