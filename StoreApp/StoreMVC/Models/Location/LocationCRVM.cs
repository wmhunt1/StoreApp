using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Hero View Model for creating and reading heroes
    /// </summary>
    public class LocationCRVM
    {
        [DisplayName("Location ID")]
        [Required]
        public int Id { get; set; }
        [DisplayName("Location Name")]
        [Required]
        public string LocationName { get; set; }

        [DisplayName("Location Address")]
        [Required]
        public string LocationAddress { get; set; }
      
    }
}