using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using EssentialTools.Models;
using Ninject;
using Ninject.Web.Common;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private IValueCalculator calc;
        private Product[] products =
        {
        new Product {Name = "Kayak", category = "Watersports", Price = 275M},
        new Product {Name = "Lifejacket", category = "Watersports", Price = 48.95M},
        new Product {Name = "Soccer ball", category = "Soccer", Price = 19.50M},
        new Product {Name = "Corner flag", category = "Soccer", Price = 34.95M},


        };

        public HomeController(IValueCalculator calcParam, IValueCalculator calc2)
        {
            calc = calcParam;
        }

        public ActionResult Index()
        {
            ;

            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);


        }

    }

}   