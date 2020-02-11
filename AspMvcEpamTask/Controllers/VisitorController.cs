using AspMvcEpamTask.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcEpamTask.Controllers
{
    public class GuestController : Controller
    {
        static GuestContainer reviewsContainer = new GuestContainer();
        // GET: Guest
        public ActionResult Index()
        {
            return View(reviewsContainer.getReviewsList());
        }
        [HttpPost]
        public ActionResult AddReview(string authorName, string reviewText)
        {
            reviewsContainer.AddReview(new Models.VisitorReview(authorName, DateTime.Now, reviewText));
            ViewData["author"] = authorName;
            return View();
        }
    }
}