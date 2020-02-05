using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _99eStuff.Models
{
    public class DetailedProductListViewModel
    {
        public int IDDetailed { get; set; }

        public string Material { get; set; }

        public int ProductWeight { get; set; }

        public string Size { get; set; }

        public int Stock { get; set; }

        public byte[] BigPicture { get; set; }

        public string Detail1 { get; set; }

        public string Detail2 { get; set; }

        public string Detail3 { get; set; }

        public string Detail4 { get; set; }

        public string Detail5 { get; set; }

        public string Description { get; set; }
    }
}