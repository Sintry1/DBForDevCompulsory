using System.ComponentModel.DataAnnotations;

namespace DBMigrations.Models
{
    public class ProductRatings
    {
        [Key]
        public int Id { get; set; }

        public int Rating { get; set; }
    }
}
