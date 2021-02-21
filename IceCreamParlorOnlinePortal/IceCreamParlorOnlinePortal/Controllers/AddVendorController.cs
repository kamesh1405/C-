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
    public class AddVendorController : Controller
    {
        OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities();
        AddVendorManager manager = new AddVendorManager();
        AddVendorModel model = new AddVendorModel();
        [Filter.AuthorizationClass]
        [HttpGet]
        public ActionResult AddVendor()
        {
            ViewBag.Message = " ";
            return View();

        }
        [HttpPost]
        public ActionResult AddVendor(AddVendorModel vend)
        {
            if (ModelState.IsValid)
            {
                vend.Vend_Add_On = DateTime.Now;
                vend.Vend_Add_by = Session["Username"].ToString();
                int a = manager.AddVendor(vend);
                if (a > 0)
                {
                    ViewBag.Message = "Data Enter Successfully with ID = " + a;
                }
                else
                {
                    ViewBag.Message = "Data Doesn't Insert";
                }
            }

            return View();
        }

        public ActionResult ViewVendor()
        {
            List<AddVendorModel> Vendor = manager.SelectVendor();
            return View(Vendor);
        }
        [HttpGet]
        public ActionResult UpdateVendor(int VendID)
        {
            AddVendorModel vend = manager.GetVend(VendID);
            if (model == null)
            {
                ViewBag.Message = "Data Not Found";
                return RedirectToAction("ViewVendor");
            }
            else
            {
                ViewBag.Message = " ";
                return View(model);
            }
        }

        [HttpPost]
        public ActionResult UpdateVendor(AddVendorModel VendID)
        {
            if (ModelState.IsValid)
            {
                VendID.Vend_Updated_On = DateTime.Now;
                VendID.Vend_Updated_By= Session["Username"].ToString();
                bool check = manager.UpdateVend(VendID);
                if (check)
                {
                    ViewBag.Message = "Data Update Successfully";
                    return RedirectToAction("ViewVendor");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        //public ActionResult DeleteVend(int VendID)
        //{
        //    bool Check = manager.DeleteVend(VendID);
        //    if (Check)
        //    {
        //        ViewBag.Message = "Data Deleted Successfully";
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Error";
        //    }
        //    return RedirectToAction("ViewVendor");
        //}

    }

}