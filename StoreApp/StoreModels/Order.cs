using System;
namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
       // public Customer orderCustomerId { get; set; }
        private int orderCustomerId;
        private int orderId;
        private string orderAddress;
        private string orderLocation;

        private int orderQuantity;

        private decimal orderTotal;
        //public double Total { get; set; }

        // private string orderCustomerName;

        // public string OrderCustomerName
        // {
        //     get { return orderCustomerName; }
        //     set
        //     {
        //         if (value == null || value.Equals(""))
        //         {
        //             // throw new ArgumentNullException("Order name can't be empty or null");
        //         }
        //         orderCustomerName = value;

        //     }
        // }
        public int? OrderId { get; set; }
        public int? OrderCustomerId { get; set; }
        // {
        //     get { return orderCustomerId; }
        //     set { orderCustomerId = value; }
        // }
        public string OrderLocation {
            get {return orderLocation;}
            set {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("order store can't be empty or null");
                }
                orderLocation = value;

            }
        }
        public string OrderAddress {
             get {return orderAddress;}
            set {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("order location can't be empty or null");
                }
                orderAddress = value;

            }
        }
        public int OrderQuantity 
        {get {return orderQuantity;}
        set {orderQuantity = value;}}
        public decimal OrderTotal 
         {get {return orderTotal;}
        set {orderTotal = value;}}

        public override string ToString() => $"Order Details: \n\t Customer ID: {this.OrderCustomerId}, {this.OrderQuantity} Cans of Soup for {this.OrderTotal}, Store and Address: {this.OrderLocation}";
    }
}