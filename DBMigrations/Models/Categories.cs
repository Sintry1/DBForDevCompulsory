using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authentication;

namespace DBMigrations.Models
{
    public class Categories
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
