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
    public class AddVendorManager
    {
        [Filter.AuthorizationClass]
        public int AddVendor(AddVendorModel vend)
        {
            int VendID = 0;
            try
            {
                using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
                {
                    tbl_IceCreamProduct_Vendor addvend = new tbl_IceCreamProduct_Vendor();
                    addvend.Vend_ID = vend.Vend_ID;
                    addvend.Vend_Name = vend.Vend_Name;
                    addvend.Vend_Company_Name = vend.Vend_Company_Name;
                    addvend.Vend_Add_On = addvend.Vend_Add_On;
                    addvend.Vend_Add_by = addvend.Vend_Add_by;
                    addvend.Vend_Updated_On = vend.Vend_Updated_On;
                    addvend.Vend_Updated_By = vend.Vend_Updated_By;
                    DB.tbl_IceCreamProduct_Vendor.Add(addvend);
                    DB.SaveChanges();
                    VendID = addvend.Vend_ID;

                };
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
            return VendID;

        }
        public AddVendorModel GetVend(int VendID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Request = DB.tbl_IceCreamProduct_Vendor.Where(x => x.Vend_ID == VendID).FirstOrDefault();
                AddVendorModel Vend = null;
                if (Request != null)
                {
                    Vend = new AddVendorModel()
                    {
                        Vend_ID = Request.Vend_ID,
                        Vend_Name = Request.Vend_Name,
                        Vend_Company_Name=Request.Vend_Company_Name,
                        Vend_Add_by = Request.Vend_Add_by,
                        Vend_Add_On = Request.Vend_Add_On,
                        Vend_Updated_By = Request.Vend_Updated_By,
                        Vend_Updated_On = Request.Vend_Updated_On
                    };
                    return Vend;
                }
                else
                {
                    return Vend;
                }
            }
        }



        public List<AddVendorModel> SelectVendor()
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var request = DB.tbl_IceCreamProduct_Vendor.ToList();
                List<AddVendorModel> List = request.Select(x => new AddVendorModel { Vend_ID = x.Vend_ID, Vend_Name= x.Vend_Name,Vend_Company_Name=x.Vend_Company_Name, Vend_Add_by = x.Vend_Add_by, Vend_Add_On= x.Vend_Add_On, Vend_Updated_On = x.Vend_Updated_On, Vend_Updated_By = x.Vend_Updated_By }).ToList();
                return List;
            }
        }
        public bool UpdateVend(AddVendorModel VendID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_IceCreamProduct_Vendor.Where(x => x.Vend_ID == VendID.Vend_ID).FirstOrDefault();
                if (Data != null)
                {
                    Data.Vend_Name = VendID.Vend_Name;
                    Data.Vend_Company_Name = VendID.Vend_Company_Name;
                    Data.Vend_Add_On = Data.Vend_Add_On;
                    Data.Vend_Add_by = Data.Vend_Add_by;
                    Data.Vend_Updated_On = VendID.Vend_Updated_On;
                    Data.Vend_Updated_By = VendID.Vend_Updated_By;
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
        public bool DeleteVend(int id)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_IceCreamProduct_Vendor.Where(x => x.Vend_ID == id).FirstOrDefault();
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