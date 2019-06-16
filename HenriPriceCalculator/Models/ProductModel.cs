using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CL_HenriPricing;

namespace HenriPriceCalculator.Models
{
    public class ProductModel
    {
        public string P1 { get; set; }
        public string M3 { get; set; }
        public string Shipping { get; set; }
        public string RRP { get; set; }
        public string BrandName { get; set; }
        public List<string> Brands { get; set; }



        public ProductModel()
        {
            List<string> brands = new List<string>();
            foreach (var item in Brand.CreateBrandList())
            {
                brands.Add(item.Name);
            }
            Brands = brands;
        }

    }
}