using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Clockwork.Core.Models;
using System.Collections.ObjectModel;

namespace Clockwork.Core.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllEntries()
        {
            return View();
        }

        public IActionResult SelectTimeZone()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Clockwork"] = "Clockwork Project";
            ViewData["Author"] = "Developer: Corey Larkin.";
            ViewData["Message"] = "Application that makes a call to an API and returns the current time.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
