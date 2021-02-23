namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
        //public Customer Customer { get; set; }
        //public Location Location { get; set; }
        //public double Total { get; set; }

        //TODO: add a property for the order items
        // private string orderName;

        // public string OrderName
        // {
        //     get { return orderName; }
        //     set
        //     {
        //         if (value == null || value.Equals(""))
        //         {
        //             // throw new ArgumentNullException("Order name can't be empty or null");
        //         }
        //         orderName = value;

        //     }
        // }
        private string orderCustomerName;

        public string OrderCustomerName
        {
            get { return orderCustomerName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    // throw new ArgumentNullException("Order name can't be empty or null");
                }
                orderCustomerName = value;

            }
        }
        public override string ToString() => $"Order Details: \n\t Customer: {this.OrderCustomerName}";
    }
}