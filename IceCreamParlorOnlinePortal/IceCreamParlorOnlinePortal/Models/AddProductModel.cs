using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;
using IceCreamParlorOnlinePortal.Models;
using System.IO;
using System.Data.Entity.Validation;
using System.ComponentModel.DataAnnotations;


namespace IceCreamParlorOnlinePortal.Models
{
    public class AddProductModel
    {
        public int IceCream_ID { get; set; }
        [Required(ErrorMessage = "Invalid Ice Cream name")]
        public string IceCream_Name { get; set; }
        [Required(ErrorMessage = "Invalid Description")]
        public string IceCream_Descrip { get; set; }
        [Required(ErrorMessage = "Invalid Image")]
        public string IceCream_Image { get; set; }
        [Required(ErrorMessage = "Invalid stock")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Invalid price")]
        public int unit_price { get; set; }
        public Nullable<int> Purchase_Price { get; set; }
        public Nullable<int> Sale_Price { get; set; }
        public DateTime IceCream_Add_On { get; set; }
        public string IceCream_Add_by { get; set; }
        public Nullable<System.DateTime> IceCream_Updated_On { get; set; }
        public string IceCream_Updated_By { get; set; }
        public int Cat_ID_fk_Cat_ID { get; set; }
        public int Vend_ID_fk_Vend_ID { get; set; }

        public HttpPostedFileBase ImageFile { get; set; }
    }
}