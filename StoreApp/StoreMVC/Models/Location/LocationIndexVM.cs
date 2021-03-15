using System.ComponentModel;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Model for the index view of my app
    /// </summary>
    public class LocationIndexVM
    {
        //Data annotation
        //Can be used for display purposes, and also for validation
         [DisplayName("Order Id")]
        public int Id { get; set; }
        [DisplayName("Location Name")]
        public string LocationName { get; set; }

         [DisplayName("Location Address")]
        public string LocationAddress { get; set; }
    }
}