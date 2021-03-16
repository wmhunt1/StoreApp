using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Hero View Model for creating and reading heroes
    /// </summary>
    public class OrderCRVM
    {
        [DisplayName("Order Id")]
        [Required]
        public int Id { get; set; }

        [DisplayName("Order Name")]
        [Required]
        public string OrderName { get; set; }

        [DisplayName("Order Customer Id")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Should be a positive number")]
        [Required]
        public int OrderCustomerId { get; set; }

        [DisplayName("Order Location Id")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Should be a positive number")]
        [Required]
        public int OrderLocationId { get; set; }

        [DisplayName("Order Contents")]
        [Required]
        public string OrderContents { get; set; }

        [DisplayName("Order Total")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Should be a positive number")]
        [Required]
        public decimal OrderTotal { get; set; }

    }
}