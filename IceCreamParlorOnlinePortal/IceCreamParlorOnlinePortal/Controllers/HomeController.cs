using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;
using IceCreamParlorOnlinePortal.Manager;
using IceCreamParlorOnlinePortal.Models;
namespace IceCreamParlorOnlinePortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.Message = " ";
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel Model)
           {
            if (Model.UserName != null && Model.User_Password !=null)
            {
                LoginManager mgr = new LoginManager();
                LoginModel user= mgr.checklogin(Model.UserName, Model.User_Password);
                if (user != null)
                {
                    if (user.User_Type==1 )
                    {
                        Session["IsLogedIn"] = true;
                        Session["LoginID"] = user.Login_ID;
                        Session["LoginType"] = user.User_Type;
                        Session["Username"] = user.UserName;
                        return RedirectToAction("AdminView", "Admin");
                    }
                }
                else
                {
                    ViewBag.Message = "Username or password in incorrect";
                    return View();
                }
            }
            else
            {
                ViewBag.Message = "Username or password in incorrect";
                return View();
            }

            return View();

        }

        public ActionResult ContactUS()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
        public ActionResult MarketPlace()
        {
            return View();
        }

        public ActionResult FAQs()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}