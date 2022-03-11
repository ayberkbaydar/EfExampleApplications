using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            Category category = new Category();
            category.CategoryName = "Baverages";

            db.Categories.Add(category);
            db.SaveChanges();

            Console.Read();
        }
    }
    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int UnitInStock { get; set; }
    }

    class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Conn")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
