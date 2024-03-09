using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace DBMigrations
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DBContext>
    {

        //Change this to the name of the local database you have, it requires the database to be created already
        private string ConnectionString = "JESPER-PC";

        public DBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DBContext>();
            optionsBuilder.UseSqlServer($"Server={ConnectionString};Database=EFCoreMigrations;Trusted_Connection=True;TrustServerCertificate=true");

            return new DBContext(optionsBuilder.Options);
        }
    }
}