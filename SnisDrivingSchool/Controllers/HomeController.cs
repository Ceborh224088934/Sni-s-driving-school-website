using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Success= "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                // TODO: save to database or send an email here
                ViewBag.Success = "Thank you! Your message has been sent — we'll be in touch soon.";
                ModelState.Clear();
            }
            return View(model);
        }
    }
}