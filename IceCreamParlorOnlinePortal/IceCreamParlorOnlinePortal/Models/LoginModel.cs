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
    public class LoginModel
    {
        public int Login_ID { get; set; }
        [Required(ErrorMessage = "Invalid Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Invalid Password")]
        public string User_Password { get; set; }
        public int User_Type { get; set; }
        public int Emp_ID_fk_Emp_ID { get; set; }
    }
}