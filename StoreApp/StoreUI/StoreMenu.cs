using System;
using NLog;
using StoreModels;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void Start()
        {
            Console.WriteLine("Menu Start");
            Boolean stay = true;
            do
            {
                //menu options part
                Console.WriteLine("=================================================");
                Console.WriteLine("Welcome to the store! What would you like to do?");
                Console.WriteLine("[1] Add a Customer");
                Console.WriteLine("[2] View Customers");
                Console.WriteLine("[3] Place Order");
                Console.WriteLine("[4] View Orders");
                Console.WriteLine("[5] View Inventory");
                Console.WriteLine("[6] Replenish Inventory");
                Console.WriteLine("[0] Exit Store.");

                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddCustomer();
                        break;
                    case "2":
                        ViewCustomers();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        ViewOrders();
                        break;
                    case "5":
                        ViewInventory();
                        break;
                    case "6":
                        ReplenishInventory();
                        break;
                    case "0":
                        stay = false;
                        LeaveStore();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            } while (stay);
        }
        public void AddCustomer()
        {
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter Customer Name: ");
            newCustomer.Name = Console.ReadLine();
        }
        public void ViewCustomers()
        {
            Console.WriteLine("Customer List");
        }
        public void SearchCustomers()
        {
            Console.WriteLine("Searching Customers");
        }
        public void PlaceOrder()
        {
            Console.WriteLine("Placing Order");
            Order newOrder = new Order();

        }
        public void ViewOrders()
        {
            Console.WriteLine("Viewing Orders");
        }
        public void DisplayOrderDetails()
        {
            Console.WriteLine("Displaying Order Details");
        }
        public void CustomerHistory()
        {
            Console.WriteLine("Customer Order History");
        }
        public void LocationHistory()
        {
            Console.WriteLine("Location history");
        }
        public void ViewInventory()
        {
            Console.WriteLine("Viewing Inventory");
        }
        public void SortOrderByDate()
        {
            Console.WriteLine("Sorting by Order Date");
        }
        public void SortOrderByPrice()
        {
            Console.WriteLine("Sorting by Order Price");
        }
        public void ReplenishInventory()
        {
            Console.WriteLine("Replenishing Inventory");
        }
        public void LeaveStore()
        {
            Console.WriteLine("Leaving Store");
        }
    }
}