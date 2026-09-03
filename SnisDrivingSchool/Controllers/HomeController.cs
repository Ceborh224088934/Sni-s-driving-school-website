using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SnisDrivingSchool.Models;

namespace SnisDrivingSchool.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View(new ContactViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: save to database or send an email here
                ViewBag.Success = "Thank you! Your message has been sent — we'll be in touch soon.";
                ModelState.Clear();
                return View(new ContactViewModel());
            }
            return View(model);
        }
    }
}
