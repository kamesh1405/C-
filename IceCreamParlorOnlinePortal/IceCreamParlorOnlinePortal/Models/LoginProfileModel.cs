using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamParlorOnlinePortal.Models
{
    public class LoginProfileModel
    {
        public int Emp_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Emp_Email { get; set; }
        public string Qualification { get; set; }
        public string Gender { get; set; }
        public string Emp_Contact { get; set; }
        public System.DateTime Emp_Add_On { get; set; }
        public string Emp_Add_by { get; set; }
        public Nullable<System.DateTime> Emp_Updated_On { get; set; }
        public string Emp_Updated_By { get; set; }
        public LoginModel credential { get; set; } 

    }
}