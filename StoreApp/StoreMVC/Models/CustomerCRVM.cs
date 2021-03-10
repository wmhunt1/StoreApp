using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Hero View Model for creating and reading heroes
    /// </summary>
    public class CustomerCRVM
    {
        [DisplayName("Customer Name")]
        [Required]
        public string CustomerName { get; set; }

        [DisplayName("Customer Address")]
        [Required]
        public string CustomerAddress { get; set; }
      
    }
}