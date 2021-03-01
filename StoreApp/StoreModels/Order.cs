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

        private int orderQuantity1;
        private int orderQuantity2;
        private int orderQuantity3;

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
        public int OrderQuantity1 
        {get {return orderQuantity1;}
        set {orderQuantity1 = value;}}
         public int OrderQuantity2 
        {get {return orderQuantity2;}
        set {orderQuantity2 = value;}}
         public int OrderQuantity3 
        {get {return orderQuantity3;}
        set {orderQuantity3 = value;}}
        public decimal OrderTotal 
         {get {return orderTotal;}
        set {orderTotal = value;}}
        public override string ToString() => $"Order Details: \n\t Customer ID: {this.OrderCustomerId}, {this.OrderQuantity1} Cans of Soup, {this.OrderQuantity2} Spoons, and {this.OrderQuantity3} Bowls for ${this.OrderTotal}, Store and Address: {this.OrderLocation}";
    }
}