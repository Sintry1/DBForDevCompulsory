﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Authentication;

namespace DBMigrations.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
<<<<<<< HEAD

        [ForeignKey("ProductRatings")]
        public int Rating_Id { get; set; }
        public ProductRatings ProductRatings { get; set; }
=======
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
>>>>>>> ef/add-categories
    }
}
