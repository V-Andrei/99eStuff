using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _99eStuff.Models
{
    public class ContactViewModel
    {
        public int IdClient { get; set; }

        public string NameClient { get; set; }

        public string Mail { get; set; }

        public string City { get; set; }

        public string Message { get; set; }
    }
}