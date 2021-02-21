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
    public class AddEmployeeModel
    {
        public int Emp_ID { get; set; }
        [Required(ErrorMessage = "Invalid First Name")]
        public string First_Name { get; set; }
        [Required(ErrorMessage = "Invalid Last Name")]
        public string Last_Name { get; set; }
        [Required(ErrorMessage = "Invalid Email Name")]
        [EmailAddress(ErrorMessage ="Invalid Email Format")]
        public string Emp_Email { get; set; }
        [Required(ErrorMessage = "Invalid Qualification")]
        public string Qualification { get; set; }
        [Required(ErrorMessage = "Invalid Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Invalid Contact")]
        public string Emp_Contact { get; set; }
        [Required(ErrorMessage = "Invalid User name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Invalid Password")]
        public string Password { get; set; }
        public int UserType { get; set; }
        public System.DateTime Emp_Add_On { get; set; }
        public string Emp_Add_by { get; set; }
        public Nullable<System.DateTime> Emp_Updated_On { get; set; }
        public string Emp_Updated_By { get; set; }



    }
}