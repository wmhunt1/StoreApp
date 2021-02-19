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
                Console.WriteLine("Welcome to the store! What would you like to do?");
                Console.WriteLine("[0] Add a Customer");
                Console.WriteLine("[1] View Customers");
                Console.WriteLine("[2] Place Order");
                Console.WriteLine("[3] View Orders");
                Console.WriteLine("[4] View Inventory");
                Console.WriteLine("[5] Replenish Inventory");
                Console.WriteLine("[6] Exit Store.");

                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        AddCustomer();
                        break;
                        // try
                        // {
                        //     PlaceOrder();
                        // }
                        // catch (Exception e)
                        // {
                        //     Console.WriteLine("invalid input." + e.Message);
                        //     continue;
                        // }
                        break;
                    case "1":
                        ViewCustomers();
                        break;
                    case "2":
                        PlaceOrder();
                        break;
                    case "3":
                        ViewOrders();
                        break;
                    case "4":
                        ViewInventory();
                        break;
                    case "5":
                        ReplenishInventory();
                        break;
                    case "6":
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
            Console.WriteLine("Placing Orders");
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