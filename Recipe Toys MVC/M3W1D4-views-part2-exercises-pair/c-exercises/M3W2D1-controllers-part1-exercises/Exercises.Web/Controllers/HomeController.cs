using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercises.Web.Models;

namespace Exercises.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult XOrder()
        {
            
            return View("XOrder");
        }
        public ActionResult XOrderResult(string firstname, string middleintial, string lastname)
        {
            Order model = new Order()
            {
                FirstName = firstname,
                MiddleInt = middleintial,
                LastName = lastname
            };
            return View("XOrderResult", model);
        }
    }
}