using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class InstructorController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Role"] as string != "Instructor")
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}