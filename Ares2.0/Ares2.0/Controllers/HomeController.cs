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

        public IActionResult Capstone()
        {
            ViewData["Message"] = "This page contains a brief description and images of my capstone project.";

            return View("Capstone");
        }

        public IActionResult Chat()
        {
            ViewData["Message"] = "This page contains a live chat for anyone to use.";

            return View("Chat");
        }

        public IActionResult Mentor()
        {
            ViewData["Message"] = "Information regarding my mentor.";

            return View("Mentor");
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
