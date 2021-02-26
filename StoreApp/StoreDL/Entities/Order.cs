using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public Customer OrderCustomer { get; set; }

        public virtual Customer OrderCustomerNavigation { get; set; }
    }
}
