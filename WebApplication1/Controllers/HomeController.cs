using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult ContactForm()
        {
            // Create a list of countries for the dropdown
            var countries = new List<SelectListItem>
        {
            new SelectListItem { Value = "USA", Text = "USA" },
            new SelectListItem { Value = "UK", Text = "UK" },
            new SelectListItem { Value = "Canada", Text = "Canada" }
        };

            // Pass the list of countries to the view via ViewBag
            ViewBag.CountryList = countries;
            return View();
        }

        // POST: /Home/SubmitContactForm
        [HttpPost]
        public ActionResult SubmitContactForm()
        {
            // Collect form data from Request.Form
            ViewBag.Name = Request.Form["Name"];
            ViewBag.Email = Request.Form["Email"];
            ViewBag.Phone = Request.Form["Phone"];
            ViewBag.Gender = Request.Form["Gender"];
            ViewBag.Country = string.Join(", ", Request.Form["Country"]);
            ViewBag.Message = Request.Form["Message"];

            // Return the result view with the collected data
            return View("ContactFormResult");
        }
    }
}