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
    public class AddCategoryManager
    {
        [Filter.AuthorizationClass]
        public int AddCategory(AddCategoryModel cat)
        {
            int CatID = 0;
            try
            {
                using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
                {
                    tbl_IceCream_Category addcat = new tbl_IceCream_Category();
                    addcat.Cat_ID = cat.Cat_ID;
                    addcat.Cat_Name = cat.Cat_Name;
                    addcat.Cat_Add_On = cat.Cat_Add_On;
                    addcat.Cat_Add_by = cat.Cat_Add_by;
                    addcat.Cat_Updated_On = cat.Cat_Updated_On;
                    addcat.Cat_Updated_By = cat.Cat_Updated_By;
                    DB.tbl_IceCream_Category.Add(addcat);
                    DB.SaveChanges();
                    CatID = addcat.Cat_ID;

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
            return CatID;

        }
        public AddCategoryModel GetCat(int CatID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Request = DB.tbl_IceCream_Category.Where(x => x.Cat_ID == CatID).FirstOrDefault();
                AddCategoryModel Cat = null;
                if (Request != null)
                {
                    Cat = new AddCategoryModel()
                    {
                        Cat_ID= Request.Cat_ID,
                        Cat_Name = Request.Cat_Name,
                        Cat_Add_by = Request.Cat_Add_by,
                        Cat_Add_On = Request.Cat_Add_On,
                        Cat_Updated_By = Request.Cat_Updated_By,
                        Cat_Updated_On = Request.Cat_Updated_On
                    };
                    return Cat;
                }
                else
                {
                    return Cat;
                }
            }
        }



        public List<AddCategoryModel> SelectCategory()
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var request = DB.tbl_IceCream_Category.ToList();
                List<AddCategoryModel> List = request.Select(x => new AddCategoryModel { Cat_ID=x.Cat_ID, Cat_Name=x.Cat_Name, Cat_Add_by=x.Cat_Add_by, Cat_Add_On=x.Cat_Add_On, Cat_Updated_On=x.Cat_Updated_On, Cat_Updated_By=x.Cat_Updated_By}).ToList();
                return List;
            }
        }
        public bool UpdateCat(AddCategoryModel Cat)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_IceCream_Category.Where(x => x.Cat_ID == Cat.Cat_ID).FirstOrDefault();
                if (Data != null)
                {
                    Data.Cat_Name = Cat.Cat_Name;
                    Data.Cat_Add_On = Data.Cat_Add_On;
                    Data.Cat_Add_by = Data.Cat_Add_by;
                    Data.Cat_Updated_On = Cat.Cat_Updated_On;
                    Data.Cat_Updated_By = Cat.Cat_Updated_By;
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
        public bool DeleteCat(int id)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_IceCream_Category.Where(x => x.Cat_ID == id).FirstOrDefault();
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