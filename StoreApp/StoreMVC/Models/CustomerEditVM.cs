using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Needed to store the Id of the hero I'm going to update
    /// </summary>
    public class CustomerEditVM
    {
        [Required]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [Required]
        [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }

        public int Id { get; set; }
 
    }
}