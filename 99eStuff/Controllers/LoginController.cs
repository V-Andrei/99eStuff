using _99eStuff.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _99eStuff.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace _99eStuff.Controllers
{
    public class LoginController : Controller
    {

        ProductRepository productsRepository = new ProductRepository();
        DataTable dt;

        // GET: /Login/
        public ActionResult LoginRegister()
        {
            return View();
        }
        public ActionResult LoginActive()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(UsersLoginViewModel userModel)
        {
            string mycmd = "select * from UserData";
            dt = new DataTable();

            dt = productsRepository.GetAll(mycmd);


            List<UsersLoginViewModel> list = new List<UsersLoginViewModel>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UsersLoginViewModel users = new UsersLoginViewModel
                {
                    UserID = Convert.ToInt32(dt.Rows[i]["IdUser"]),
                    UserName = dt.Rows[i]["UserName"].ToString(),
                    Password = dt.Rows[i]["Passsword"].ToString(),
                };

                list.Add(users);
            }

                var userDetails = list.Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMessage = "Wrong username or password.";
                    return View("LoginRegister", userModel);
                }
                else
                {
                    Session["userID"] = userDetails.UserID;
                    Session["userName"] = userDetails.UserName;
                    return RedirectToAction("LoginActive", "Login");
                }
        }

        public ActionResult LogOut()
        {
            int userId = (int)Session["userID"];
            Session.Abandon();
            return RedirectToAction("LoginRegister", "Login");
        }
    }
}