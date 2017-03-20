using ShoppingWebSite.Models;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWebSite.Controllers
{
    public class ProductController : Controller
    {
        ShoppingdbEntities sdb = new ShoppingdbEntities();

        // GET: Product
        public ActionResult Index()
        {
            List<Products> prodlist = new List<Products>()
            {
                new Products { ID = 1, Category = "Mobiles", Name = "IPhone 7s",QuantityAvail = 13, Price = 750.39, imagesrc="AppleIPhone.jpg"},
                new Products { ID = 2, Category = "Electonics", Name = "HP Laptop",QuantityAvail = 19, Price = 609.00, imagesrc="HPLaptop.jpeg"},
                new Products { ID = 3, Category = "Home Appliance", Name = "Electric Kettle",QuantityAvail = 7, Price = 29.99, imagesrc="Kettle.jpeg" },
                new Products { ID = 4, Category = "Computers", Name = "LapTop & Tablet",QuantityAvail = 20, Price = 499.99, imagesrc="LaptopTablet.jpeg" },
                new Products { ID = 5, Category = "Apparel", Name = "Loafers",QuantityAvail = 45, Price = 39.99, imagesrc="Loafers.jpeg" },
                new Products { ID = 6, Category = "Tools & Home Improvement", Name = "Measuring Tape",QuantityAvail = 12, Price = 20.00, imagesrc="Measuringtape.jpeg" },
                new Products { ID = 7 , Category = "Apparel", Name = "Smart Watch",QuantityAvail = 20, Price = 399.99, imagesrc="SamsungGear.jpeg" },
                new Products { ID = 8, Category = "Home Appliance", Name = "Sandwich Maker",QuantityAvail = 44, Price = 109.39,imagesrc="SandwichMaker.jpeg" }

            };
            

            return View(prodlist);
        }

        public ActionResult Buy()
        {
            return View();
        }
        



}
}