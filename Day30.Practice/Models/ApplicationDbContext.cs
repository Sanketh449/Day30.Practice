using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Day30.Practice.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("EclerxMVC")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Clothes> Clothes { get; set; }
      
    }
}