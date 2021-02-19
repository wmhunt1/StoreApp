using System;
//using StoreModels;

namespace StoreUI
{
    public class StoreMenu : IMenu
    {
        public void Start()
        {
            Console.WriteLine("Menu Start");
            Boolean stay = true;
            do
            {
                 //menu options part
                Console.WriteLine("Welcome to the store! What would you like to do?");
                Console.WriteLine("[0] Place an Order");
                Console.WriteLine("[1] View All Orders");
                Console.WriteLine("[2] Exit.");

                //get user input
                Console.WriteLine("Enter a number: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        try
                        {
                            PlaceOrder();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("invalid input." + e.Message);
                            continue;
                        }
                        break;
                    case "1":
                        ViewOrders();
                        break;
                    case "2":
                        stay = false;
                        LeaveStore();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            } while(stay);
        }
        public void PlaceOrder()
        {
            Console.WriteLine("Placing Order");
        }
        public void ViewOrders()
        {
            Console.WriteLine("Viewing Orders");
        }
        public void LeaveStore()
        {
            Console.WriteLine("Leaving Store");   
        }
    }
}