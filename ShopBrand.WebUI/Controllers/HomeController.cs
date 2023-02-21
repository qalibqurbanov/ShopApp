using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopBrand.WebUI.Models.Entities;

namespace ShopBrand.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact model)
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }
    }
}
