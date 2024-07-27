using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcShop
{
    public class ProductDTO
    {
        public int UrunId { get; set; }
        public string UrunAd { get; set; }
        public decimal BirimFiyat { get; set; }
    }
}