using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class SepetController : BaseController
    {
        // GET: Sepet
        public ActionResult Ekle()
        {
            ICollection<ProductDTO> slist = db.Products.Select(x => new ProductDTO
            {
                UrunId = x.ProductID,
                UrunAd = x.ProductName,
                BirimFiyat = (decimal)x.UnitPrice


            }).Where(x=> x.UrunId<4).ToList();

            Session["Sepet"] = slist;
            Session["Msg"] = "Ürünler sepete eklendi";
            return RedirectToAction("Index", "Home");
            
            
            
            
        }
    }
}