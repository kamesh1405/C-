using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;
using IceCreamParlorOnlinePortal.Models;
using System.IO;
using System.Data.Entity.Validation;

namespace IceCreamParlorOnlinePortal.Manager
{
    public class AddEmployeeManager
    {
        [Filter.AuthorizationClass]
        public int AddEmployee(AddEmployeeModel addemp)
        {
            int EmpID = 0;
            try
            {
                using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
                {
                    tbl_Employee emp = new tbl_Employee();
                  
                    emp.First_Name = addemp.First_Name;
                    emp.Last_Name = addemp.Last_Name;
                    emp.Gender = addemp.Gender;
                    emp.Qualification = addemp.Qualification;
                    emp.Emp_Contact = addemp.Emp_Contact;
                    emp.Emp_Email = addemp.Emp_Email;
                    emp.Emp_Add_by = addemp.Emp_Add_by;
                    emp.Emp_Add_On = addemp.Emp_Add_On;
                    emp.Emp_Updated_By = addemp.Emp_Updated_By;
                    emp.Emp_Updated_On = addemp.Emp_Updated_On;
                    DB.tbl_Employee.Add(emp);

                    tbl_Login log = new tbl_Login();
                    log.UserName = addemp.Username;
                    log.User_Password = addemp.Password;
                    log.User_Type = addemp.UserType;
                    log.Emp_ID_fk_Emp_ID = emp.Emp_ID;
                    DB.tbl_Login.Add(log);
                    DB.SaveChanges();
                    EmpID = emp.Emp_ID;
                }

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            return EmpID;


        }

        public AddEmployeeModel GetEmp(int EmpID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Request = DB.tbl_Employee.Where(x => x.Emp_ID == EmpID).FirstOrDefault();
                AddEmployeeModel emp = null;
                
                if (Request != null)
                {
                   emp = new AddEmployeeModel()
                    {
                        Emp_ID = Request.Emp_ID,
                        First_Name = Request.First_Name,
                        Last_Name = Request.Last_Name,
                        Emp_Email= Request.Emp_Email,
                        Emp_Contact = Request.Emp_Contact,
                       Gender= Request.Gender,
                       Emp_Add_On = Request.Emp_Add_On,
                       Emp_Add_by = Request.Emp_Add_by,
                        Emp_Updated_By = Request.Emp_Updated_By,
                        Emp_Updated_On = Request.Emp_Updated_On
                    };
                    return emp;
                }
                else
                {
                    return emp;
                }
            }
        }



        public List<AddEmployeeModel> SelectEmp()
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var request = DB.tbl_Employee.ToList();
                List<AddEmployeeModel> List = request.Select(x => new AddEmployeeModel { Emp_ID = x.Emp_ID, First_Name = x.First_Name, Last_Name = x.Last_Name,Gender=x.Gender,Qualification=x.Qualification, Emp_Email= x.Emp_Email,Emp_Contact = x.Emp_Contact, Emp_Add_by= x.Emp_Add_by,Emp_Add_On = x.Emp_Add_On, Emp_Updated_By = x.Emp_Updated_By, Emp_Updated_On = x.Emp_Updated_On}).ToList();
                return List;
            }
        }
        public bool Updateemp(AddEmployeeModel EmpID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_Employee.Where(x => x.Emp_ID == EmpID.Emp_ID).FirstOrDefault();
                if (Data != null)
                {
                    Data.First_Name= EmpID.First_Name;
                    Data.Last_Name = EmpID.Last_Name;
                    Data.Gender = EmpID.Gender;
                    Data.Qualification = EmpID.Qualification;
                    Data.Emp_Email= EmpID.Emp_Email;
                    Data.Emp_Contact= EmpID.Emp_Contact;
                    Data.Emp_Add_On = Data.Emp_Add_On;
                    Data.Emp_Updated_On = EmpID.Emp_Updated_On;
                    Data.Emp_Add_by = Data.Emp_Add_by;
                    Data.Emp_Updated_By = EmpID.Emp_Updated_By;
                    DB.Entry(Data).State = EntityState.Modified;
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Deleteemp(int id)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_Employee.Where(x => x.Emp_ID == id).FirstOrDefault();
                if (Data != null)
                {
                    DB.Entry(Data).State = EntityState.Deleted;
                    DB.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}