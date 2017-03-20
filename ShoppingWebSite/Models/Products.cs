using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingWebSite.Models
{
    public class Products
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        public int QuantityAvail { get; set; }
        public string Category { get; set; }
        public string imagesrc { get; set; }
    }
}