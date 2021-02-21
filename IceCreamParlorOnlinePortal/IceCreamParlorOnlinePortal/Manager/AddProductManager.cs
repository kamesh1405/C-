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
    public class AddProductManager
    {
        [Filter.AuthorizationClass]
        public int AddProduct(AddProductModel add)
        {
            int productID = 0;
            try
            {
                using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
                {
                    tbl_IceCream_Product pro = new tbl_IceCream_Product();
                    pro.IceCream_Name = add.IceCream_Name;
                    pro.Stock = add.Stock;
                    pro.IceCream_Descrip = add.IceCream_Descrip;
                    pro.unit_price = add.unit_price;
                    pro.IceCream_Image = add.IceCream_Image;
                    pro.Cat_ID_fk_Cat_ID = add.Cat_ID_fk_Cat_ID;
                    pro.Vend_ID_fk_Vend_ID = add.Vend_ID_fk_Vend_ID;
                    pro.IceCream_Add_On = add.IceCream_Add_On;
                    pro.IceCream_Add_by = add.IceCream_Add_by;
                    pro.IceCream_Updated_On = add.IceCream_Updated_On;
                    pro.IceCream_Updated_By = add.IceCream_Updated_By;
                    DB.tbl_IceCream_Product.Add(pro);
                    DB.SaveChanges();
                    productID = pro.IceCream_ID ;

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
            return productID;

        }
        public AddProductModel Getpro(int proID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Request = DB.tbl_IceCream_Product.Where(x => x.IceCream_ID == proID).FirstOrDefault();
                AddProductModel pro = null;
                if (Request != null)
                {
                    pro = new AddProductModel()
                    {
                        IceCream_ID = Request.IceCream_ID,
                        IceCream_Name = Request.IceCream_Name,
                        IceCream_Descrip = Request.IceCream_Descrip,
                        Cat_ID_fk_Cat_ID=Request.Cat_ID_fk_Cat_ID,
                        Vend_ID_fk_Vend_ID=Request.Vend_ID_fk_Vend_ID,
                        unit_price=Request.unit_price,
                        Purchase_Price=Request.Purchase_Price,
                        Sale_Price=Request.Sale_Price,
                        Stock=Request.Stock,
                        IceCream_Add_by = Request.IceCream_Add_by,
                        IceCream_Add_On = Request.IceCream_Add_On,
                        IceCream_Updated_By = Request.IceCream_Updated_By,
                        IceCream_Updated_On = Request.IceCream_Updated_On,
                        IceCream_Image=Request.IceCream_Image
                    };
                    return pro;
                }
                else
                {
                    return pro;
                }
            }
        }



        public List<AddProductModel> Selectpro()
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var request = DB.tbl_IceCream_Product.ToList();
                List<AddProductModel> List = request.Select(x => new AddProductModel{IceCream_ID = x.IceCream_ID, IceCream_Name = x.IceCream_Name, IceCream_Descrip = x.IceCream_Descrip,unit_price=x.unit_price,Vend_ID_fk_Vend_ID=x.Vend_ID_fk_Vend_ID,Cat_ID_fk_Cat_ID=x.Cat_ID_fk_Cat_ID,Purchase_Price=x.Purchase_Price,Sale_Price=x.Sale_Price,Stock=x.Stock, IceCream_Add_by = x.IceCream_Add_by, IceCream_Add_On = x.IceCream_Add_On, IceCream_Updated_On = x.IceCream_Updated_On, IceCream_Updated_By= x.IceCream_Updated_By ,IceCream_Image=x.IceCream_Image}).ToList();
                return List;
            }
        }
        public bool Updatepro(AddProductModel proID)
        {
            using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
            {
                var Data = DB.tbl_IceCream_Product.Where(x => x.IceCream_ID == proID.IceCream_ID).FirstOrDefault();
                if (Data != null)
                {
                    Data.IceCream_Name = proID.IceCream_Name;
                    Data.IceCream_Descrip = proID.IceCream_Descrip;
                    Data.unit_price = proID.unit_price;
                    Data.Purchase_Price = proID.Purchase_Price;
                    Data.Sale_Price = proID.Sale_Price;
                    Data.Stock = proID.Stock;
                    Data.Cat_ID_fk_Cat_ID = Data.Cat_ID_fk_Cat_ID;
                    Data.Vend_ID_fk_Vend_ID = Data.Vend_ID_fk_Vend_ID;
                    Data.IceCream_Add_On= Data.IceCream_Add_On;
                    Data.IceCream_Add_by = Data.IceCream_Add_by;
                    Data.IceCream_Updated_On = proID.IceCream_Updated_On;
                    Data.IceCream_Updated_By = proID.IceCream_Updated_By;
                    Data.IceCream_Image = proID.IceCream_Image;
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
        //public bool Deletepro(int id)
        //{
        //    using (OnlineIceCreamPortalEntities DB = new OnlineIceCreamPortalEntities())
        //    {
        //        var Data = DB.tbl_IceCream_Product.Where(x => x.IceCream_ID == id).FirstOrDefault();
        //        if (Data != null)
        //        {
        //            DB.Entry(Data).State = EntityState.Deleted;
        //            DB.SaveChanges();
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

    }
}