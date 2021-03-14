using System.ComponentModel;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Model for the index view of my app
    /// </summary>
    public class OrderIndexVM
    {
         [DisplayName("Order Id")]
        public int Id { get; set; }
        
        [DisplayName("Order Name")]
        public string OrderName { get; set; }

        [DisplayName("Order Customer Id")]
        public int OrderCustomerId { get; set; }

        [DisplayName("Order Location Id")]
        public int OrderLocationId { get; set; }

        [DisplayName("Order Contents")]
        public string OrderContents { get; set; }

        [DisplayName("Order Total")]
        public decimal OrderTotal { get; set; }
    }
}