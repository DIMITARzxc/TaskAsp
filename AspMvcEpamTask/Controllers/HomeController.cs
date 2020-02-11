using AspMvcEpamTask.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMvcEpamTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArticleContainer articleContainer = new ArticleContainer();
            return View(articleContainer.getArticles());
        }

    }
}