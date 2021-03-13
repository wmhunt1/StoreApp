using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Needed to store the Id of the hero I'm going to update
    /// </summary>
    public class LocationEditVM
    {
        [Required]
        [DisplayName("Location Name")]
        public string LocationName { get; set; }

        [Required]
        [DisplayName("Location Address")]
        public string LocationAddress { get; set; }

        public int Id { get; set; }
 
    }
}