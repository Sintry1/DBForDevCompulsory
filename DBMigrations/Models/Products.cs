using Microsoft.AspNetCore.Authentication;

namespace DBMigrations.Models
{
    public class Products
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
