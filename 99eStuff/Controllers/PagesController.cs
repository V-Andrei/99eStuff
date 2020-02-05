using _99eStuff.BusinessLogic;
using _99eStuff.Data;
using _99eStuff.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _99eStuff.Controllers
{
    public class PagesController : Controller
    {
        private readonly IProductsRepository productsRepository;
        private readonly IDetailedProductsRepository detailedProductsRepository;

        public PagesController()
        {
            this.productsRepository = new ProductRepository(ConnectionManager.GetConnection());
            this.detailedProductsRepository = new DetailedProductRepository(ConnectionManager.GetConnection());
        }

        public ActionResult Cart()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult LoginRegister()
        {
            return View();
        }
        public ActionResult ProductDetails()
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

            List<DetailedProducts> allDetailedProducts = this.detailedProductsRepository.GetAll();

            List<DetailedProductListViewModel> detailedProductLists = new List<DetailedProductListViewModel>();

            foreach (var detailed in allDetailedProducts)
            {
                detailedProductLists.Add(new DetailedProductListViewModel
                {
                    IDDetailed = detailed.IDDetailed,
                    Material = detailed.Material,
                    ProductWeight = detailed.ProductWeight,
                    Size = detailed.Size,
                    Stock = detailed.Stock,
                    BigPicture = detailed.BigPicture,
                    Detail1 = detailed.Detail1,
                    Detail2 = detailed.Detail2,
                    Detail3 = detailed.Detail3,
                    Detail4 = detailed.Detail4,
                    Detail5 = detailed.Detail5,
                    Description = detailed.Description
                });

            }

            DetailedProductAndProdcutsViewModel finalProduct = new DetailedProductAndProdcutsViewModel();
            finalProduct.Products = productsList;
            finalProduct.detailedProducts = detailedProductLists;

            return this.View(finalProduct);
        }
        public ActionResult Wishlist()
        {
            return View();
        }
    }
}