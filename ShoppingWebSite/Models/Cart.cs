using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingWebSite.Models
{
    public class Cart
    {
        public ProductTable CartItems { get; set;}
        public decimal CartValue { get; set; }
    }
}