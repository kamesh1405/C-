﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IceCreamParlorOnlinePortal.Filter
{
    public class AuthorizationClass : System.Web.Mvc.ActionFilterAttribute, System.Web.Mvc.IActionFilter
    {
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["IsLogedIn"] == null)
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
                {
                    {"Controller", "Home"},
                    {"Action", "Login"}
                });

            }
            base.OnActionExecuting(filterContext);
        }
    }
}