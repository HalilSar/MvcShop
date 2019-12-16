using MvcShop.Models.Data;
using MvcShop.Models.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class LoginController  : BaseController
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            LoginModel model = new LoginModel();

            Session["categoriesList"] = CategoriesFill.GetCategories();

            return View(model);
        }
        [HttpPost]//dogru mu yanlış mı
        public ActionResult Login(LoginModel model)
        {
            User user = db.User.Find(model.UserId);
            if (user != null)
            {
                if(user.Password == model.Password)
                {
                    Session["User"] = user.UserName;
                    Session["Role"] = user.Role;//ADMİN Mİ NORMAL KİŞİ Mİ
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Error"] = "Yanlış şifre veya User girildi.";
                    return View();
                }

            }
            

            return View();
        }
        public ActionResult Logout()
        {
             Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}