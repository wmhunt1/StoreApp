using System;

namespace StoreModels
{
    /// <summary>
    /// Data structure used for modeling a hero.
    /// </summary>
    public class Customer
    {
        private string customerName;
        private string customerAddress;
        //something for order history
        private int id;
        public int Id { get; set; }
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer name can't be empty or null");
                }
                customerName = value;

            }
        }
        public string CustomerAddress
        {
            get { return customerAddress; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer address can't be empty or null");
                }
                customerAddress = value;

            }
        }
        //someone for order history

        public override string ToString() => $"Customer Details: \nCustomer Id: {this.Id}\n name: {this.CustomerName} \n address: {this.CustomerAddress}";
    }
}
