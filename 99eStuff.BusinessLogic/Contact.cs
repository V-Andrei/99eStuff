using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace _99eStuff.BusinessLogic
{
    class Contact
    {
        public int Idlient { get; set; }

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
