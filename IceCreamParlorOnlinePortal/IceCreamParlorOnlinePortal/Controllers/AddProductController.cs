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
    public class AddProductController : Controller
    {
        OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities();
        AddProductManager manager = new AddProductManager();
        AddProductModel model = new AddProductModel();
        [Filter.AuthorizationClass]
        [HttpGet]
        public ActionResult AddProduct()
        {
            ViewBag.Cat = db.tbl_IceCream_Category.Select(x => new SelectListItem { Text = x.Cat_Name, Value = x.Cat_ID.ToString() }).ToList();
            ViewBag.Vend = db.tbl_IceCreamProduct_Vendor.Select(x => new SelectListItem { Text = x.Vend_Name, Value = x.Vend_ID.ToString() }).ToList();
            ViewBag.Message = " ";
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(AddProductModel add)
        {
            if (ModelState.IsValid)
            {
                string Filename = Path.GetFileNameWithoutExtension(add.ImageFile.FileName);
                string Extension = Path.GetExtension(add.ImageFile.FileName);
                Filename = Filename + DateTime.Now.ToString("yymmssfff") + Extension;
                add.IceCream_Image = "~/Images/" + Filename;
                Filename = Path.Combine(Server.MapPath("~/Images/"), Filename);
                add.ImageFile.SaveAs(Filename);
                add.IceCream_Add_On = DateTime.Now;
                add.IceCream_Add_by = Session["Username"].ToString();

                int a = manager.AddProduct(add);
                if (a > 0)
                {
                    ViewBag.Message = "Data Enter Successfully with ID = " + a;
                }
                else
                {
                    ViewBag.Message = "Data Doesn't Insert";
                }
            }
            ViewBag.Cat = db.tbl_IceCream_Category.Select(x => new SelectListItem { Text = x.Cat_Name, Value = x.Cat_ID.ToString() }).ToList();
            ViewBag.Vend = db.tbl_IceCreamProduct_Vendor.Select(x => new SelectListItem { Text = x.Vend_Name, Value = x.Vend_ID.ToString() }).ToList();


            return View();
        }
        public ActionResult ViewProduct()
        {
            List<AddProductModel> pro = manager.Selectpro();
            return View(pro);
        }
      
        [HttpGet]
        public ActionResult Updatepro(int proID)
        {
        AddProductModel pro = manager.Getpro(proID);
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
        public ActionResult UpdatePro(AddProductModel proID)
        {
            if (ModelState.IsValid)
            {
                proID.IceCream_Updated_On = DateTime.Now;
                proID.IceCream_Updated_By= Session["Username"].ToString();
                bool check = manager.Updatepro(proID);
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

        //public ActionResult DeleteVend(int proID)
        //{
        //    bool Check = manager.Deletepro(proID);
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