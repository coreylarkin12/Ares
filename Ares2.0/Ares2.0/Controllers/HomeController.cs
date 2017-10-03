using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ares2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A talented programmer.";

            return View("About");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Please contact me to set up interviews.";

            return View("Contact");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
