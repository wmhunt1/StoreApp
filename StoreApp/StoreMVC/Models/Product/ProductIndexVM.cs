using System.ComponentModel;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Model for the index view of my app
    /// </summary>
    public class ProductIndexVM
    {
        [DisplayName("Product ID")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]

        public string ProductDesc { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }

        [DisplayName("Product Quantity")]
        public int ProductQuantity { get; set; }
        [DisplayName("Product Location Id")]
        public int ProductLocation { get; set; }
    }
}