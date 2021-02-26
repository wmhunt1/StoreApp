using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int OrderCustomerId { get; set; }

        public virtual Customer OrderCustomer { get; set; }
    }
}
