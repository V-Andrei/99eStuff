using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _99eStuff.Models
{
    public class DetailedProductAndProdcutsViewModel
    {
        public List<ProductsListViewModel> Products { get; set; }

        public List<DetailedProductListViewModel> detailedProducts { get; set; }
    }
}