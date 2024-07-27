using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class HomeController : BaseController
    {
        NorthwindEntities1 db = DBSingleton.GetNorthwind();
      
        public ActionResult Products(int id)
        {
           
            Session["productsList"] = db.Products.Where(x=>x.CategoryID==id).ToList();
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            CatList();
            return View();
        }
        public void CatList()
        {
            Session["categoriesList"] = CategoriesFill.GetCategories();

        }
    }
}