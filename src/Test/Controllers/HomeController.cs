using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var test = 1;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Test Branch1";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
