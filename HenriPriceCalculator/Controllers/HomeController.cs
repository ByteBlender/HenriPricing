using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HenriPriceCalculator.Models;

namespace HenriPriceCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string txtP1, string txtM3, string BrandName)
        {
            ProductModel p = new ProductModel();
            double m3 = 0;
            double p1 = 0;
            if(!string.IsNullOrWhiteSpace(txtP1) || !string.IsNullOrWhiteSpace(txtP1))
            {
                p.P1 = txtP1;
                p.M3 = txtM3;
                p1 = double.TryParse(txtP1, out p1)? p1 : 0;
                m3= double.TryParse(txtM3, out  m3) ? m3 : 0;
                double shipping = CL_HenriPricing.Pricing.CalcShipping(m3, BrandName);
                p.Shipping = shipping.ToString();
                p.RRP = CL_HenriPricing.Pricing.CalcRRP(BrandName, p1, shipping).ToString();

            }
         
            return View(p);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}