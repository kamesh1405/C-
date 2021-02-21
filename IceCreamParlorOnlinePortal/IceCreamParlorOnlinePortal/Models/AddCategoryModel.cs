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
    public class AddCategoryModel
    {
        public int Cat_ID { get; set; }
        [Display(Name ="Category Name")]
        [Required(ErrorMessage = "Invalid Category Name")]
        public string Cat_Name { get; set; }
        public System.DateTime Cat_Add_On { get; set; }
        public string Cat_Add_by { get; set; }
        public Nullable<System.DateTime> Cat_Updated_On { get; set; }
        public string Cat_Updated_By { get; set; }
        //public LoginModel credential { get; set; }

    }
}