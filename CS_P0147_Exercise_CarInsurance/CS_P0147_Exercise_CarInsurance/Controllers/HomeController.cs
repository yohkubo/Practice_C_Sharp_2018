using CS_P0147_Exercise_CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS_P0147_Exercise_CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Client(string firstName, string lastName, string emailAddress, 
            int birthYear, int birthMonth, int birthDay,
            int carYear, string make, string model, int speedingTickets)//, bool dui, bool fullCoverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (CarInsuranceEntities db = new CarInsuranceEntities())
                {
                    var client = new Client();
                    client.FirstName = firstName;
                    client.LastName = lastName;
                    client.EmailAddress = emailAddress;
                    string birthday = birthYear + "-" + birthMonth + "-" + birthDay;
                    client.Birthday = Convert.ToDateTime(birthday);
                    
                    //client.Dui = dui;
                    //client.FullCoverage = fullCoverage;

                    db.Clients.Add(client);
                    db.SaveChanges();
                }
                return View("Success");
            }
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