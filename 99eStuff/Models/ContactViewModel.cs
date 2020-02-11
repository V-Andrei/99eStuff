using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _99eStuff.Models
{
    public class ContactViewModel
    {
        [Required]
        public int IdClient { get; set; }

        [Required]
        public string NameClient { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Message { get; set; }
    }
}