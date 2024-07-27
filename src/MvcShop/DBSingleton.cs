using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop
{
    public static class DBSingleton
    {
        static NorthwindEntities1 db;
        public static NorthwindEntities1 GetNorthwind()
        {
            if (db == null)
            {
                db = new NorthwindEntities1();

            }
            return db;
        }

    }
}