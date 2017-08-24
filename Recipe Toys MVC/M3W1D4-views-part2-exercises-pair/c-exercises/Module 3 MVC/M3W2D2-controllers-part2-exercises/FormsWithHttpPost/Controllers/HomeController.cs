using FormsWithHttpPost.DAL;
using FormsWithHttpPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Configuration;

namespace FormsWithHttpPost.Controllers
{
    public class HomeController : Controller
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["squirrelReviews"].ToString();
        ReviewSqlDAL reviewDAL;

        // GET: Home
        public HomeController()
        {
            reviewDAL = new ReviewSqlDAL(connectionString);
        }

        public ActionResult SquirrelReview()
        {
            return View("SquirrelReview");
        }

        public ActionResult SquirrelReviewResult(string username, string title, string message)
        {
            Review model = new Review()
            {
                Username = username,
                Title = title,
                Message = message
            };
            return View("SquirrelReviewResult", model);
        }
        [HttpPost]
        public ActionResult SquirrelReviewResult(Review post)
        {
            reviewDAL.SaveReview(post);

            return View("SquirrelReviewResult");
        }
    }
}