using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ShoppingWebSite.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        public int d;
        static List<ProductTable> cartList = new List<ProductTable>();

        ShoppingdbEntities ss = new ShoppingdbEntities();
        // GET: Cart

        public ActionResult Index(int? id)
        {
            var dl = new List<SelectListItem>();
            dl.Add(new SelectListItem { Text = "1", Value = "1", Selected = true });
            dl.Add(new SelectListItem { Text = "2", Value = "2" });
            dl.Add(new SelectListItem { Text = "3", Value = "3" });
            dl.Add(new SelectListItem { Text = "4", Value = "4" });
            dl.Add(new SelectListItem { Text = "5", Value = "5" });
            dl.Add(new SelectListItem { Text = "6", Value = "6" });
            dl.Add(new SelectListItem { Text = "7", Value = "7" });
            dl.Add(new SelectListItem { Text = "8", Value = "8" });
            dl.Add(new SelectListItem { Text = "9", Value = "9" });
            dl.Add(new SelectListItem { Text = "10", Value = "10" });
            ViewBag.Values = dl;

            if (cartList.Count() > 0)
            {
                var s = cartList.Where(x => x.Id == id).FirstOrDefault();
                if (s == null)
                {
                    
                }
                else
                {
                    ProductTable productTable = ss.ProductTables.Find(id);
                    productTable.Quantity = dl;
                    //productTable.StaticPrice = productTable.Price;
                    // productTable.StaticQuantity = quantity;
                    cartList.Add(productTable);
                    //some alert
                }
            }
            else
            {
                if (id == null)
                {
                    return View(cartList);
                    // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                ProductTable productTable = ss.ProductTables.Find(id);
                productTable.Quantity = dl;
                productTable.StaticPrice = productTable.Price;
                cartList.Add(productTable);
                if (productTable == null)
                {
                    return HttpNotFound();
                }
            }
            return View(cartList);
        }

        public ActionResult Delete(int? id)
        {
            ProductTable p = ss.ProductTables.Find(id);
            var x = cartList.Single(pr => pr.Id == id);
            cartList.Remove(x);
            return View("Index", cartList);
        }

        [HttpPost]
        public ActionResult UpdateProduct(int prodID, int quantity)
        {
            var x = cartList.Single(pr => pr.Id == Convert.ToInt32(Request.Form[0].ToString()));
            x.StaticPrice = Convert.ToString(Convert.ToDecimal(x.Price) * quantity);
            cartList.Add(x);
            //foreach (var item in x.Quantity)
            //{
            //    if (item.Value == Convert.ToString(quantity))
            //    {
            //        item.Selected = true;
            //    }
            //    else
            //    {
            //        item.Selected = false;
            //    }
            //}

            return View("Index", cartList);
        }

        public ActionResult OnSuccess()
        {
            //reduce availquantity by quantity
            return RedirectToAction("Index", "ProductTables");
        }
    }
}