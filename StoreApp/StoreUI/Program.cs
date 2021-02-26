using StoreBL;
using StoreDL;
using StoreDL.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //setting up db connection
            string connectionString = configuration.GetConnectionString("StoreDB");
            DbContextOptions<StoreDBContext> options = new DbContextOptionsBuilder<StoreDBContext>()
            .UseSqlServer(connectionString)
            .Options;

            //using statement used to dispose of the context when its no longer used 
            using var context = new StoreDBContext(options);
            IMenu menu = new StoreMenu(
              new CustomerBL(new CustomerRepoFile())
            , new ItemBL(new ItemRepoFile())
            , new LocationBL(new LocationRepoFile())
            , new OrderBL(new OrderRepoFile())
            , new ProductBL(new ProductRepoFile()));
            menu.Start();
        }
    }
}
