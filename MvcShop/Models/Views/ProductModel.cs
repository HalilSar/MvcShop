using MvcShop.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop.Models.Views
{
    public class ProductModel
    {
        public ICollection<Categories> categoiesList { get; set; }
        public ICollection<Products> productsList { get; set; }
    }
}