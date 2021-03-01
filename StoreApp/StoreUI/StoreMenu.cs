using System;
using StoreModels;
using System.Linq;
using StoreBL;
using System.Collections;
using System.Collections.Generic;
using NLog;
namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private ICustomerBL _customerBL;

        private IItemBL _itemBL;
        private ILocationBL _locationBL;
        private IOrderBL _orderBL;
        private IProductBL _productBL;

        private static Logger logger = LogManager.GetCurrentClassLogger();
        public StoreMenu(ICustomerBL customerBL, IItemBL itemBL, ILocationBL locationBL, IOrderBL orderBL, IProductBL productBL)
        {
            _customerBL = customerBL;
            _itemBL = itemBL;
            _locationBL = locationBL;
            _orderBL = orderBL;
            _productBL = productBL;

        }
        Boolean inventory = false;
        Boolean order = false;
        public void Start()
        {
            Boolean stay = true;
            do
            {
                //menu options part
                Console.WriteLine("=====================[Just Soup]=====================");
                Console.WriteLine("Welcome to Just Soup! Can we get you any soup today?");
                Console.WriteLine("[1] Add a Customer");
                Console.WriteLine("[2] View Customers");
                Console.WriteLine("[3] Search Customers");
                Console.WriteLine("[4] Place Order");
                Console.WriteLine("[5] View Orders");
                Console.WriteLine("[6] View Inventory By Location");
                Console.WriteLine("[7] Replenish Inventory");
                Console.WriteLine("[8] Order History by Location");
                Console.WriteLine("[9] Test");
                Console.WriteLine("[0] Exit Store.");

                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        try
                        {
                            CreateCustomer();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("invalid input." + e.Message);
                            continue;
                        }
                        break;
                    case "2":
                        GetCustomers();
                        break;
                    case "3":
                        SearchCustomers();
                        break;
                    case "4":
                        CreateOrder();
                        break;
                    case "5":
                        GetOrders();
                        break;
                    case "6":
                        //inventory by location
                        inventory = true;
                        SearchLocations();
                        break;
                    case "7":
                        ReplenishInventory();
                        break;
                    case "8":
                        order = true;
                        //location order history
                        SearchLocations();
                        break;
                    case "9":
                        Test();
                        break;
                    case "0":
                        stay = false;
                        ExitRemarks();
                        break;
                    default:
                        Console.WriteLine("Invalid input! Not part of menu options! >:[");
                        break;
                }
            } while (stay);
        }
        public void CreateCustomer()
        {
            _customerBL.AddCustomer(GetCustomerDetails());
            Console.WriteLine("Customer Succesfully Added!");
            AnyButton();

        }
        public void GetCustomers()
        {
            foreach (var item in _customerBL.GetCustomers())
            {
                Console.WriteLine(item.ToString());
            }
            AnyButton();

        }
        public void SearchCustomers()
        {
            Console.WriteLine("Enter customer full name: ");
            Customer foundCustomer = _customerBL.GetCustomerByName(Console.ReadLine());
            if (foundCustomer == null)
            {
                Console.WriteLine("No customer found.");
                AnyButton();
            }
            else
            {
                Console.WriteLine("customer found.");
                Console.WriteLine(foundCustomer.ToString());
                AnyButton();
                Console.WriteLine("Customer Order History");
                int foundId = Convert.ToInt32(foundCustomer.CustomerId);
                CustomerOrderHistory(foundId);
                AnyButton();
            }
        }
        public void CustomerOrderHistory(int x)
        {
            foreach (var item in _orderBL.GetOrders())
            {
                if (item.OrderCustomerId == x)
                {
                    Console.WriteLine(item.ToString());
                }
                else
                {
                    //Console.WriteLine("Customer has no order history");
                }
            }
        }
        public void CreateOrder()
        {
            //need a thing for if no customers
            Console.WriteLine("Placing Order");
            _orderBL.AddOrder(GetOrderDetails());
            Console.WriteLine("Order Succesfully placed at...");
            logger.Error("");
            AnyButton();
            //return newOrder;
        }
        public void GetOrders()
        {
            foreach (var item in _orderBL.GetOrders())
            {
                Console.WriteLine(item.ToString());
            }
            AnyButton();
            Console.WriteLine("Would you like to sort the orders by total? Y/N");
            string sortChoice = Console.ReadLine();
            List<Order> orderList = _orderBL.GetOrders();
            List<Order> sorted = orderList.OrderBy(x => x.OrderTotal)
                                    .ThenBy(x => x.OrderCustomerId)
                                    .ToList();
            if (sortChoice == "Y")
            {
                Console.WriteLine(String.Join(Environment.NewLine, sorted));
            }
            else
            {

            }
            AnyButton();

        }
        public void ReplenishInventory()
        {
            Console.WriteLine("Replenishing Inventory");
            // Console.WriteLine("Enter store name");
            // Location location2BUpdated = _locationBL.GetLocationByName(Console.ReadLine());
            // if (location2BUpdated == null)
            // {
            //     Console.WriteLine("Location not found");
            // }
            // else
            // {
            //     AnyButton();
            //     _locationBL.UpdateLocation(location2BUpdated, GetLocationDetails(location2BUpdated));
            //     Console.WriteLine("Inventory Replenished");
            // }
            AnyButton();
        }
        // private Location GetLocationDetails(Location x)
        // {
        // Location newLocation = new Location();
        // newLocation.LocationName = x.LocationName;
        // newLocation.StreetAddress = x.StreetAddress;
        // newLocation.LocationInventory = 200;

        // return newLocation;
        // }
        private Customer GetCustomerDetails()
        {
            Console.WriteLine("Adding Customer");
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter Customer Name: ");
            newCustomer.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Address: ");
            newCustomer.CustomerAddress = Console.ReadLine();

            return newCustomer;

        }
        private Order GetOrderDetails()
        {
            Order newOrder = new Order();
            var i = 0;
            List<Customer> customerList = _customerBL.GetCustomers();
            foreach (var item in customerList)
            {
                Console.WriteLine(i + ": " + item.ToString());
                i++;
            }
            var choice = GetInputInt("Select Customer from List");
            int chosenCustomer = Convert.ToInt32(customerList[choice].CustomerId);
            newOrder.OrderCustomerId = chosenCustomer;
            Console.WriteLine("Add Items to Cart");
            AnyButton();
            bool shopping = true;
            List<Product> productList = _productBL.GetProducts();
            while (shopping == true)
            {
                var j = 0;
                foreach (var item in productList)
                {
                    Console.WriteLine(j + ": " + item.ProductName + ", $" + item.Price);
                    j++;
                }
                var choice3 = GetInputInt("Which product would you like to buy?");
                Product chosenProduct = productList[choice3];
                if (chosenProduct.ProductName == "Soup")
                {
                    newOrder.OrderQuantity1 = GetInputInt($"How many {chosenProduct.ProductName} would you like to buy?");
                }
                else if (chosenProduct.ProductName == "Spoons")
                {
                    newOrder.OrderQuantity2 = GetInputInt($"How many {chosenProduct.ProductName} would you like to buy?");
                }
                else
                {
                    newOrder.OrderQuantity3 = GetInputInt($"How many {chosenProduct.ProductName} would you like to buy?");
                }

                Console.WriteLine($"Would you like to continue shoping? Y/N");
                string keepShopping = Console.ReadLine();
                if (keepShopping == "Y")
                {
                    var l = 0;
                    foreach (var item in productList)
                    {
                        Console.WriteLine((l + ": " + item.ProductName + ", $" + item.Price));
                        l++;
                    }
                    var choice4 = GetInputInt("Which product would you like to buy?");
                    Product chosenProduct2 = productList[choice4];
                    if (chosenProduct2.ProductName == "Soup")
                    {
                        int moreSoup = GetInputInt($"How many cans of {chosenProduct2.ProductName} would you like to buy?");
                        newOrder.OrderQuantity1 = moreSoup + newOrder.OrderQuantity1;
                    }
                    else if (chosenProduct2.ProductName == "Spoons")
                    {
                        int moreSpoons = GetInputInt($"How many {chosenProduct2.ProductName} would you like to buy?");
                        newOrder.OrderQuantity2 = moreSpoons + newOrder.OrderQuantity2;
                    }
                    else
                    {
                        int moreBowls = GetInputInt($"How many {chosenProduct2.ProductName} would you like to buy?");
                        newOrder.OrderQuantity3 = moreBowls + newOrder.OrderQuantity3;
                    }
                }
                else
                {
                    shopping = false;
                }
            }
            AnyButton();
            newOrder.OrderTotal = newOrder.OrderQuantity1 * productList[0].Price + newOrder.OrderQuantity2 * productList[1].Price + newOrder.OrderQuantity3 * productList[2].Price;
            var k = 0;
            List<Location> locationList = _locationBL.GetLocations();
            foreach (var item in locationList)
            {
                Console.WriteLine(k + ": " + item.LocationName);
                k++;
            }
            var choice2 = GetInputInt("Select Store from List");
            string chosenLocation = locationList[choice2].LocationName;
            string chosenAddress = locationList[choice2].StreetAddress;
            newOrder.OrderLocation = chosenLocation;
            newOrder.OrderAddress = chosenAddress;
            Console.WriteLine(newOrder.ToString());
            return newOrder;

        }
        public void SearchLocations()
        {
            Console.WriteLine("Enter location full name: ");
            Location foundLocation = _locationBL.GetLocationByName(Console.ReadLine());
            if (foundLocation == null)
            {
                Console.WriteLine("No location found.");
                AnyButton();
            }
            else
            {
                Console.WriteLine("location found.");
                Console.WriteLine(foundLocation.ToString());
                AnyButton();
                Console.WriteLine("Location Order History");
                string foundName = foundLocation.LocationName;
                if (order == true)
                {
                    LocationOrderHistory(foundName);
                }
                else
                {
                    LocationInventory(foundName);
                }
                AnyButton();
            }
        }
        public void LocationOrderHistory(string x)
        {
            foreach (var item in _orderBL.GetOrders())
            {
                if (item.OrderLocation == x)
                {
                    Console.WriteLine(item.ToString());
                }
                else
                {
                }
            }
            order = false;
        }
        public void LocationInventory(string x)
        {
            Console.WriteLine("Location Inventory");
            inventory = false;
            foreach (var item in _locationBL.GetLocations())
            {
                if (item.LocationName == x)
                {
                    Console.WriteLine(item.GetInventory());
                }
                else
                {
                    //Console.WriteLine("Customer has no order history");
                }
            }
        }
        public void AnyButton()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void ExitRemarks()
        {
            Console.WriteLine("No Soup for You!");
        }
        public void Test()
        {
        }
        public static void GetInput(String str)
        {
            str = String.Format(" - {0}: ", str);
            Console.Write(str);
        }
        public static int GetInputInt(string message)
        {
            int input = -10;
            while (input == -10)
            {
                try
                {
                    GetInput(message);
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e) //Error
                {
                    input = -10;
                    Console.WriteLine(e.Message);
                }
            }
            return input;
        }
    }
}