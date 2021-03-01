using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Order>();
        }

        public int LocationId { get; set; }
        public string StreetAddress { get; set; }
        public string LocationName { get; set; }
        public int LocationInventory1 { get; set; }
        public int LocationInventory2 { get; set; }
        public int LocationInventory3 { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
