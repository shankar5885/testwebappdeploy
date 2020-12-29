using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Modified About";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Modified Contact";

            return View();
        }
    }
}
