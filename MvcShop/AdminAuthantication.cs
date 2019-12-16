using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop
{
    public class AdminAuthantication : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            if (HttpContext.Current.Session["Role"] .ToString() != "Admin")
            {
                //HttpContext.Current.Session["Error"] = "Bu sayfaya girmek için önce login olmalısınız";
                filterContext.Result = new HttpStatusCodeResult(401,"Yetki olmayan sayfa");

            }
        }
    }
}