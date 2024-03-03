using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schema_Migrations_Assignment2.Model
{
    public class Products
    {
        //Create products based on Initial database schema.sql
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; } 
        public int CategoryID { get; set; }

        public Products(int productID, string productName, decimal productPrice, int categoryID)
        {
            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            CategoryID = categoryID;
        }
    }
}
