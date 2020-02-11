using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AspMvcEpamTask.Controllers
{
    public class FormController : Controller
    {
        // GET: Profile
        public ActionResult Index(string[] PeppersBox, string groupBox, string hiphopbut)
        {
            if (HttpContext.Request.HttpMethod == "POST")
            {
                int percent = 0;
                string result = "";
                foreach (string rockbox in PeppersBox)
                {
                    result += rockbox;
                }
                result += groupBox;
                result += hiphopbut;
                if (result.Contains("1995") && result.Contains("1974") && result.Contains("1983") && result.Contains("2000"))
                {
                    percent += 10;
                }
                if (result.Contains("Rock"))
                {
                    percent += 10;
                }
                if (result.Contains("three"))
                {
                    if (percent == 20)
                        percent += 11;
                    else percent += 10;
                }

                ViewData["music"] = percent;
                return View("ProfileResult");
            }
            else
            {
                return View();
            }

        }
    }
}