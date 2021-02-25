using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Customer
    {
        //public int Id { get; set; }
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }

        public int CId { get; set; }
    
    }
}
