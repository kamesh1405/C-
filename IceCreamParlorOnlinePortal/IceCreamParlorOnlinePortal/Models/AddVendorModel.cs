using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;
using IceCreamParlorOnlinePortal.Manager;
using System.ComponentModel.DataAnnotations;

namespace IceCreamParlorOnlinePortal.Models
{
    public class AddVendorModel
    {
        public int Vend_ID { get; set; }
        [Required(ErrorMessage = "Invalid Vendor Name")]
        public string Vend_Name { get; set; }
        [Required(ErrorMessage = "Invalid Vendor Company")]
        public string Vend_Company_Name { get; set; }
        public System.DateTime Vend_Add_On { get; set; }
        public string Vend_Add_by { get; set; }
        public Nullable<System.DateTime> Vend_Updated_On { get; set; }
        public string Vend_Updated_By { get; set; }
 



    }
}