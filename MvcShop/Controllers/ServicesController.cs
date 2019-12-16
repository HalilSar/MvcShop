using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcShop.Controllers
{
    public class ServicesController : BaseController
    {
      //  NorthwindEntities db = DBSingleton.GetNorthwind();

         
        public  ActionResult Services()
        {

            return Index();
        }
    }
}