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
        private int orderLocationId;

        private int orderQuantity1;
        private int orderQuantity2;
        private int orderQuantity3;

        private decimal orderTotal;
        public int? OrderId { get; set; }
        public int? OrderCustomerId { get; set; }

        public int? OrderLocationId { get; set; }
        // {
        //     get { return orderCustomerId; }
        //     set { orderCustomerId = value; }
        // }
        public int OrderQuantity1
        {
            get { return orderQuantity1; }
            set { orderQuantity1 = value; }
        }
        public int OrderQuantity2
        {
            get { return orderQuantity2; }
            set { orderQuantity2 = value; }
        }
        public int OrderQuantity3
        {
            get { return orderQuantity3; }
            set { orderQuantity3 = value; }
        }
        public decimal OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }
        public override string ToString() => $"Order Details: \n\t Customer ID: {this.OrderCustomerId}, {this.OrderQuantity1} Cans of Soup, {this.OrderQuantity2} Spoons, and {this.OrderQuantity3} Bowls for ${this.OrderTotal}, Store ID: {this.OrderLocationId}";
    }
}