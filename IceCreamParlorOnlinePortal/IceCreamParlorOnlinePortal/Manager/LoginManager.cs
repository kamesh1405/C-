using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IceCreamParlorOnlinePortal.Models;
using System.Data.Entity;
using IceCreamParlorOnlinePortal.Filter;

namespace IceCreamParlorOnlinePortal.Manager
{
    public class LoginManager
    {
        public LoginModel checklogin(string username, string password)
        {
            using (OnlineIceCreamPortalEntities db = new OnlineIceCreamPortalEntities())
            {
                var request = db.tbl_Login.Where(x => x.UserName == username && x.User_Password == password).FirstOrDefault();
                LoginModel login = null;

                if (request != null)
                {
                    login = new LoginModel()
                    {
                    Login_ID = request.Login_ID,
                    UserName = request.UserName,
                    User_Password = request.User_Password,
                    User_Type = request.User_Type,
                    Emp_ID_fk_Emp_ID = request.Emp_ID_fk_Emp_ID

                };
                    return login;
                }
                else
                {
                    return login;
                }
            }

        }
    }
}