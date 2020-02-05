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
        private readonly IDetailedProductsRepository detailedProductsRepository;

        public HomeController()
        {
            productsRepository = new ProductRepository(ConnectionManager.GetConnection());
            detailedProductsRepository = new DetailedProductRepository(ConnectionManager.GetConnection());
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<ProductsListViewModel> productsList = ProductList();

            return View(productsList);
        }

        private List<ProductsListViewModel> ProductList()
        {
            List<Products> allProducts = this.productsRepository.GetAll();

            List<ProductsListViewModel> productsList = new List<ProductsListViewModel>();

            foreach (var product in allProducts)
            {
                productsList.Add(new ProductsListViewModel
                {
                    ID = product.ID,
                    IDDetailed = product.IDDetailed,
                    NameProduct = product.NameProduct,
                    Category = product.Category,
                    CurrentPrice = product.CurrentPrice,
                    OldPrice = product.OldPrice,
                    SmallPicture = product.SmallPicture
                });
            }

            return productsList;
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
            List<ProductsListViewModel> productsList = ProductList();

            return View(productsList);
        }
    }
}