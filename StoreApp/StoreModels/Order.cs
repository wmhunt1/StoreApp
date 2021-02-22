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
        private string orderName;

        public string OrderName
        {
            get { return orderName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    // throw new ArgumentNullException("Order name can't be empty or null");
                }
                orderName = value;

            }
        }
        // public int HP { get; set; }
        // public Element ElementType { get; set; }
        // public SuperPower SuperPower { get; set; }

        public override string ToString() => $"Order Details: \n\t name: {this.OrderName}";
    }
}