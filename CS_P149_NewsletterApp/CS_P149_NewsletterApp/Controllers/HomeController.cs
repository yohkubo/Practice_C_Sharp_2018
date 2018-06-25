using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS_P149_NewsletterApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            ViewBag.Title = "Kicks";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}