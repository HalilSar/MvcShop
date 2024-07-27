using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    [AdminAuthantication]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }
    }
}