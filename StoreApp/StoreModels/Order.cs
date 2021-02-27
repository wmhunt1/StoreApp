namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
       // public Customer orderCustomerId { get; set; }
        public int orderCustomerId { get; set; }
        public int orderId { get; set; }
        //public Location Location { get; set; }
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

        public override string ToString() => $"Order Details: \n\t Customer: {this.OrderCustomerId}";
    }
}