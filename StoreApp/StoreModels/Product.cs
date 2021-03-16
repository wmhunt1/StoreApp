using System;
namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        //private int id { get; set; }
        private string productName;

        private string productDesc;
        private decimal price;
        private int id;
        public string ProductName
        {
            get { return productName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("product name can't be empty or null");
                }
                productName = value;
            }
        }
         public string ProductDesc
        {
            get { return productDesc; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("product name can't be empty or null");
                }
                productDesc = value;
            }
        }
        public decimal Price { get; set; }
        public int Id;
        public int ProductQuantity;
        public int ProductLocation;
        //todo: add more properties to define a product (maybe a category?)
        public override string ToString() => $"Product Details: Product Name {this.ProductName}, Price: {this.Price}";
    }
}