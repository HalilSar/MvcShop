using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop
{
    public class UserAuthantication : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["User"] == null)
            {
                HttpContext.Current.Session["Error"] = "Bu sayfaya girmek için önce login olmalısınız";
                filterContext.Result = new RedirectResult("/Login/Login");

            }

        }
    }
}
