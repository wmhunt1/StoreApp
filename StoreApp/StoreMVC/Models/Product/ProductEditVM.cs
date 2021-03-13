using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Needed to store the Id of the hero I'm going to update
    /// </summary>
    public class ProductEditVM
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
        public decimal Price { get; set; }
 
    }
}