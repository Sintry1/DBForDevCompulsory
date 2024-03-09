using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;

namespace DBMigrations.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
