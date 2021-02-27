using System;
using StoreModels;
using StoreBL;
using System.Collections;
using System.Collections.Generic;
namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        private ICustomerBL _customerBL;

        private IItemBL _itemBL;
        private ILocationBL _locationBL;
        private IOrderBL _orderBL;
        private IProductBL _productBL;
        public StoreMenu(ICustomerBL customerBL,IItemBL itemBL, ILocationBL locationBL, IOrderBL orderBL, IProductBL productBL)
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
                       Console.WriteLine("Function not yet implemented");
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
            Console.WriteLine("Order Succesfully placed!");
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
        }
        public void ReplenishInventory()
        {
            Console.WriteLine("Replenishing Inventory");
        }
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
            Console.WriteLine("Select Customer from List");
            var i = 0;
            List<Customer> customerList = _customerBL.GetCustomers();
            foreach (var item in customerList)
            {
                Console.WriteLine(i + ": " + item.ToString());
                i++;
            }
            var choice = Convert.ToInt32(Console.ReadLine());
            int chosenCustomer = Convert.ToInt32(customerList[choice].CustomerId);
            newOrder.OrderCustomerId  = chosenCustomer;
            Console.WriteLine("Add Items to Cart");
            AnyButton();
            var j = 0;
            List<Product> productList = _productBL.GetProducts();
            foreach (var item in productList)
            {
                Console.WriteLine(j + ": " + item.ProductName + ", $" + item.Price);
                j++;
            }
            Console.WriteLine("Select Store from List");
            var k = 0;
            List<Location> locationList = _locationBL.GetLocations();
            foreach (var item in locationList)
            {
                Console.WriteLine(k + ": " + item.LocationName);
                k++;
            }
            var choice2 = Convert.ToInt32(Console.ReadLine());
            string chosenLocation = locationList[choice2].LocationName;
            string chosenAddress = locationList[choice2].StreetAddress;
            newOrder.OrderLocation = chosenLocation;
            newOrder.OrderAddress = chosenAddress;
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
            //  foreach (var item in _orderBL.GetOrders())
            // {
            //     if (item.OrderLocation == x)
            //     {
            //         Console.WriteLine(item.ToString());
            //     }
            //     else
            //     {
            //         //Console.WriteLine("Customer has no order history");
            //     }
            // }
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
        public void Test(){
         
        }
    }
}