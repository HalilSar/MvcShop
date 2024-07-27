using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class BaseController : Controller
    {
        public NorthwindEntities1 db = DBSingleton.GetNorthwind();
        public ActionResult Index()
        {
            Session["categoriesList"] = CategoriesFill.GetCategories();
            return View();
        }
    }
}