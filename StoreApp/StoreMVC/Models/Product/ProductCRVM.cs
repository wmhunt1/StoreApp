using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Hero View Model for creating and reading heroes
    /// </summary>
    public class ProductCRVM
    {
        [DisplayName("Product Id")]
        [Required]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        [Required]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]
        [Required]
        public string ProductDesc { get; set; }

        [DisplayName("Price")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Should be a positive number")]
        public decimal Price { get; set; }

        [DisplayName("Product Quantity")]
        [Required]
        [Range(0, Int32.MaxValue, ErrorMessage = "Should be a positive number")]
        public int ProductQuantity { get; set; }
        [DisplayName("Product Location Id")]
        [Required]
        public int ProductLocation { get; set; }

    }
}