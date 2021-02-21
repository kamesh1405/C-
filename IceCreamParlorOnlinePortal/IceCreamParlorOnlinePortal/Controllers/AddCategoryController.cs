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
    public class AddCategoryController : Controller
    {
        OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities();
        AddCategoryManager manager = new AddCategoryManager();
        [Filter.AuthorizationClass]
        [HttpGet]
        public ActionResult AddCategory()
        {
            ViewBag.Message = " ";
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(AddCategoryModel cat)
        {
            if (ModelState.IsValid)
            {
                AddCategoryManager obj = new AddCategoryManager();
                cat.Cat_Add_On = DateTime.Now;
                cat.Cat_Add_by = Session["Username"].ToString();
                int a = manager.AddCategory(cat);
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

        public ActionResult ViewCategory()
        {
            List<AddCategoryModel> Category = manager.SelectCategory();
            return View(Category);
        }
        [HttpGet]
        public ActionResult UpdateCat(int CatID)
        {
            AddCategoryModel cat = manager.GetCat(CatID);
            if (cat == null)
            {
                ViewBag.Message = "Data Not Found";
                return RedirectToAction("ViewCategory");
            }
            else
            {
                ViewBag.Message = " ";
                return View(cat);
            }
        }

        [HttpPost]
        public ActionResult UpdateCat(AddCategoryModel CatID)
        {
            if (ModelState.IsValid)
            {
                CatID.Cat_Updated_On = DateTime.Now;
                CatID.Cat_Updated_By = Session["Username"].ToString();
                bool check = manager.UpdateCat(CatID);
                if (check)
                {
                    ViewBag.Message = "Data Update Successfully";
                    return RedirectToAction("ViewCategory");
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

        //public ActionResult DeleteCat(int CatID)
        //{
        //    bool Check = manager.DeleteCat(CatID);
        //    if (Check)
        //    {
        //        ViewBag.Message = "Data Deleted Successfully";
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Error";
        //    }
        //    return RedirectToAction("ViewCategory");
        //}
    }
}