using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStock.Models;

namespace ProductStock.DbContexts
{
    class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("ProductDb") { }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Category> Categories { get; set; }

        
    }
    
}
