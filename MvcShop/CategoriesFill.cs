
using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop
{
    public static  class CategoriesFill
    {
        // static NorthwindEntities db = new NorthwindEntities();
        static NorthwindEntities1 db;
        static ICollection<Categories> clist;
        public static  ICollection<Categories> GetCategories()
        {
            db = DBSingleton.GetNorthwind();
            if (clist == null) 
            {
                clist = db.Categories.ToList();
            }

            return clist;
            

        }
    }
}