using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.username = Request["name"];
            ViewBag.phone = Request["phone"];
            ViewBag.contactmethod = Request["contactMethod"];
            ViewBag.country = Request["country"];
            if(!String.IsNullOrEmpty( Request["interests"]))
            ViewBag.interests = Request["interests"].Split(',');


            return View();
        }

    }
}