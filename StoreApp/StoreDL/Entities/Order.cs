using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        //public string OrderCustomerName { get; set; }
        public int OrderId { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
