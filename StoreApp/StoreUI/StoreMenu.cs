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
        private IOrderBL _orderBL;

        private IProductBL _productBL;
        public StoreMenu(ICustomerBL customerBL, IOrderBL orderBL, IProductBL productBL)
        {
            _customerBL = customerBL;
            _orderBL = orderBL;
            _productBL = productBL;
        }
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
                        try
                        {
                            CreateOrder();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("invalid input." + e.Message);
                            continue;
                        }
                    break;
                          case "4":
                        GetOrders();
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
            Console.WriteLine("Adding Customer");
            Customer newCustomer = new Customer();
            Console.WriteLine("Enter Customer Name: ");
            newCustomer.CustomerName = Console.ReadLine();
             Console.WriteLine("Enter Customer Address: ");
            newCustomer.CustomerAddress = Console.ReadLine();
            _customerBL.AddCustomer(newCustomer);
            Console.WriteLine("Customer Succesfully Added!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
        public void GetCustomers()
        {
            foreach (var item in _customerBL.GetCustomers())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
        public void CreateOrder()
        {
            Console.WriteLine("Placing Order");
            Order newOrder = new Order();
            //Console.WriteLine("Enter Order Name: ");
            //newOrder.OrderName = Console.ReadLine();
            //newOrder.OrderName = "Test";
            Console.WriteLine("Select Customer from List");
            var i = 0;
            List<Customer> customerList = _customerBL.GetCustomers();
            foreach (var item in customerList)
            {
                Console.WriteLine(i + ": " + item.CustomerName);
                i++;
            }
            var choice = Convert.ToInt32(Console.ReadLine());
            newOrder.OrderCustomerName = customerList[choice].CustomerName;
            //Need to be able to select customer from list
            //next need products and quantity along with total
            //a loop to add items and quantity until done
            _orderBL.AddOrder(newOrder);
            Console.WriteLine("Order Succesfully placed!");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void GetOrders()
        {
            foreach (var item in _orderBL.GetOrders())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
        public void ViewInventory()
        {
            Console.WriteLine("Viewing Inventory");
        }
        public void ReplenishInventory()
        {
            Console.WriteLine("Replenishing Inventory");
        }
        public void ExitRemarks()
        {
            Console.WriteLine("No Soup for You!");
        }
    }
}