﻿using System.ComponentModel;
using StoreModels;

namespace StoreMVC.Models
{
    /// <summary>
    /// Model for the index view of my app
    /// </summary>
    public class ProductIndexVM
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [DisplayName("Product Description")]

        public string ProductDesc { get; set; }

        [DisplayName("Price")]
        public decimal Price { get; set; }
    }
}