using _99eStuff.BusinessLogic;
using _99eStuff.Data;
using _99eStuff.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _99eStuff.Controllers
{
    public class AddToCartController : Controller
    {

        DataTable dt;
        ProductRepository productRepository = new ProductRepository();
        // GET: AddToCart
        public ActionResult Add(ProductsListViewModel prod)
        {

            if (Session["cart"] == null)
            {
                List<ProductsListViewModel> li = new List<ProductsListViewModel>();

                li.Add(prod);
                Session["cart"] = li;
                ViewBag.cart = li.Count();


                Session["count"] = 1;


            }
            else
            {
                List<ProductsListViewModel> li = (List<ProductsListViewModel>)Session["cart"];
                li.Add(prod);
                Session["cart"] = li;
                ViewBag.cart = li.Count();
                Session["count"] = Convert.ToInt32(Session["count"]) + 1;

            }
            return RedirectToAction("Index", "Home");


        }

        public ActionResult Cart()
        {

            return View((List<ProductsListViewModel>)Session["cart"]);

        }

        public ActionResult Remove(ProductsListViewModel prod)
        {
            List<ProductsListViewModel> li = (List<ProductsListViewModel>)Session["cart"];
            li.RemoveAll(x => x.ID == prod.ID);
            Session["cart"] = li;
            Session["count"] = Convert.ToInt32(Session["count"]) - 1;
            return RedirectToAction("Cart", "AddToCart");
            //return View();
        }
    }
}