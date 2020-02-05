using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _99eStuff.Models
{
    public class ProductsListViewModel
    {
        public int ID { get; set; }

        public int IDDetailed { get; set; }

        public string NameProduct { get; set; }

        public string Category { get; set; }

        public decimal CurrentPrice { get; set; }

        public decimal OldPrice { get; set; }

        public byte[] SmallPicture { get; set; }
    }
}