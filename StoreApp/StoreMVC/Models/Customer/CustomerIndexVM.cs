using System.ComponentModel;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Model for the index view of my app
    /// </summary>
    public class CustomerIndexVM
    {
        //Data annotation
        //Can be used for display purposes, and also for validation
         [DisplayName("Customer ID")]
        public int Id { get; set; }
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

         [DisplayName("Customer Address")]
        public string CustomerAddress { get; set; }
    }
}