using StoreBL;
using StoreDL;
namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new StoreMenu(new CustomerBL(new CustomerRepoFile()), new OrderBL(new OrderRepoFile()));
            menu.Start();
        }
    }
}
