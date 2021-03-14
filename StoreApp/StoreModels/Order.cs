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
        private int id;
        private int orderLocationId;

        private int orderQuantity1;
        private int orderQuantity2;
        private int orderQuantity3;

        private decimal orderTotal;
        public int? Id { get; set; }
        public int? OrderCustomerId { get; set; }

        public int OrderLocationId { get; set; }
        public decimal OrderTotal
        {
            get { return orderTotal; }
            set { orderTotal = value; }
        }
        public override string ToString() => $"Order Details: \n\t Customer ID: {this.OrderCustomerId}, Store ID: {this.OrderLocationId}";
    }
}