using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreModels;

namespace StoreDL
{
    public class StoreDBContext :DbContext
    {
         public StoreDBContext(DbContextOptions options) : base(options)
        {
        }
         protected StoreDBContext()
        {
        }
        public DbSet<Customer> Customers { get; set; }
        // public DbSet<Item> Items { get; set; }
        // public DbSet<Location> Locations { get; set; }
        // public DbSet<Order> Orders { get; set; }
        // public DbSet<Product> Products { get; set; }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Id)
                .ValueGeneratedOnAdd();
            
        }
    }
    
}
