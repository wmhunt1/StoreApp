using System;
namespace StoreModels
{
    //This class should contain all necessary fields to define a product.
    public class Product
    {
        private string productName;

        private decimal price;
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
        public decimal Price { get; set; }
        //todo: add more properties to define a product (maybe a category?)
        public override string ToString() => $"Product Details: Product Name {this.ProductName}, Price: {this.Price}";
    }
}