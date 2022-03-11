using CodeFirstAspNetWebApplication.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstAspNetWebApplication.DbContextClass
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext() : base("Conn")
        {

        }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}