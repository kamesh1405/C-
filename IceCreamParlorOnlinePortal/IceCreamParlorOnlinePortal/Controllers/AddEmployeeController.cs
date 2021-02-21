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
    public class AddEmployeeController : Controller
    {
        OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities();
        AddEmployeeManager manager = new AddEmployeeManager();
        [Filter.AuthorizationClass]
        [HttpGet]
        public ActionResult AddEmployee()
        {
            ViewBag.Message = " ";
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(AddEmployeeModel addemp)
        {
            if (ModelState.IsValid)
            {

                addemp.Emp_Add_On = DateTime.Now;
                addemp.Emp_Add_by = Session["Username"].ToString();
                int a = manager.AddEmployee(addemp);
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
        public ActionResult ViewEmployee()
        {
            List<AddEmployeeModel>emp = manager.SelectEmp();
            return View(emp);
        }
        [HttpGet]
        public ActionResult Updateemp(int EmpID)
        {
            AddEmployeeModel emp = manager.GetEmp(EmpID);
            if (emp == null)
            {
                ViewBag.Message = "Data Not Found";
                return RedirectToAction("ViewEmployee");
            }
            else
            {
                ViewBag.Message = " ";
                return View(emp);
            }
        }

        [HttpPost]
        public ActionResult Updateemp(AddEmployeeModel EmpID)
        {
            if (ModelState.IsValid)
            {
                EmpID.Emp_Updated_On = DateTime.Now;
                EmpID.Emp_Updated_By = Session["Username"].ToString();
                bool check = manager.Updateemp(EmpID);
                if (check)
                {
                    ViewBag.Message = "Data Update Successfully";
                    return RedirectToAction("ViewEmployee");
                }
                else
                {
                    ViewBag.Message = "Data not Update";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        //public ActionResult Deleteemp(int EmpID)
        //{
        //    bool Check = manager.Deleteemp(EmpID);
        //    if (Check)
        //    {
        //        ViewBag.Message = "Data Deleted Successfully";
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Error";
        //    }
        //    return RedirectToAction("ViewEmployee");
        //}


    }
}