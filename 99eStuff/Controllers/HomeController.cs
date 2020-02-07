using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using _99eStuff.BusinessLogic;
using _99eStuff.Data;
using _99eStuff.Models;

namespace _99eStuff.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository productsRepository;

        public HomeController()
        {
            productsRepository = new ProductRepository(ConnectionManager.GetConnection());
        }

        [HttpGet]
        public ActionResult Index()
        {
            return ProductAndDetailed();
        }

        private ActionResult ProductAndDetailed()
        {
            List<Products> allProducts = this.productsRepository.GetAll();

            List<ProductsListViewModel> productsList = new List<ProductsListViewModel>();

            foreach (var product in allProducts)
            {
                productsList.Add(new ProductsListViewModel
                {
                    ID = product.ID,
                    NameProduct = product.NameProduct,
                    Category = product.Category,
                    Stock = product.Stock,
                    CurrentPrice = product.CurrentPrice,
                    OldPrice = product.OldPrice,
                    SmallPicture = product.SmallPicture,
                    BigPicture = product.BigPicture,
                    Description = product.Description,
                    Detail1 = product.Detail1,
                    Detail2 = product.Detail2,
                    Detail3 = product.Detail3,
                    Detail4 = product.Detail4,

                });
            }

            return View(productsList);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Shop()
        {
            return ProductAndDetailed();
        }
    }
}