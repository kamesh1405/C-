using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;
using IceCreamParlorOnlinePortal.Manager;
using IceCreamParlorOnlinePortal.Models;
using System.IO;

namespace IceCreamParlorOnlinePortal.Controllers
{
    public class AdminController : Controller
    {
        OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities();
       [Filter.AuthorizationClass]

        public ActionResult AdminView()
        {
            return View();
        }
        public ActionResult AdminProfile()
        {
            return View();
        }
        public ActionResult ContactUS()
        {
            return View();
        }
        public ActionResult ViewCustomerCheckOut()
        {
            return View();
        }
    }
}