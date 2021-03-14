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
        [Required]
        public int OrderCustomerId { get; set; }

         [DisplayName("Order Location Id")]
        [Required]
        public int OrderLocationId { get; set; }

        [DisplayName("Order Contents")]
        [Required]
        public string OrderContents { get; set; }

        [DisplayName("Order Total")]
        [Required]
        public decimal OrderTotal { get; set; }
      
    }
}