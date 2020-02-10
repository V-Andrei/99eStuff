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
        public ActionResult LoginRegister()
        {
            return View();
        }
    }
}