using CS_P143_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS_P143_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 30;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid page.mannnnnnnnn!!!!");

            //return View();
        }

        public ActionResult Contact(string id="Kent")
        {
            ViewBag.Message = "Today's lucky number is:" + id;

            return View();
        }
    }
}