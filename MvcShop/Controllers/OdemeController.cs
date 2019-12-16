using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    [UserAuthantication]//login olmadan
    public class OdemeController : BaseController
    {
        
        
        public ActionResult Odeme()
        {
            List<ProductDTO> sepet = (List<ProductDTO>)Session["sepet"];

            return View(sepet);
        }
    }
}