using Inventory_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Inventory_app.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Login(Account model)
        //{
        //    string user_name = model.UserName;

        //    string user_password = model.UserPassword;

        //    if(user_name != "" && user_password != "")
        //    {
        //        if(user_name == "Raian" && user_password == "123456")
        //        {
        //            ViewBag.Massege = "Login Success!";
        //            RedirectToAction("Dashboard", "Home");
        //        }
        //        else
        //        {
        //            ViewBag.Massege = "Login Failed";
        //        }

        //    }
        //    else
        //    {
        //        ViewBag.Massege = "Input given";
        //    }

        //    return View();

        //}


        [HttpPost]
        public ActionResult Login(Account model)
        {
            string user_name = model.UserName;
            string user_password = model.UserPassword;

            if (String.IsNullOrEmpty(user_name) && String.IsNullOrEmpty(user_password))
                ViewBag.Message = "Login Neended" ;

            if (user_name == "Raian" && user_password == "123456")
                {
                Session["user"] = user_name;
                    ViewBag.Message = "Login Success!";
                    return RedirectToAction("Dashboard", "Home"); // Return the redirect result
                }
                else
                {
                    ViewBag.Message = "Login Failed";
                }
            
          

            return View();
        }



    }
}