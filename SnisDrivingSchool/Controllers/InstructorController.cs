using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class InstructorController : Controller
    {
        private bool IsInstructor()
        {
            return Session["Role"] as string == "Instructor";
        }

        public ActionResult Index()
        {
            if (!IsInstructor())
                return RedirectToAction("Login", "Account");

            return RedirectToAction("Schedule");
        }

        public ActionResult Schedule()
        {
            if (!IsInstructor())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Students()
        {
            if (!IsInstructor())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        public ActionResult AddAvailability(string AvailableDate, string StartTime, string EndTime)
        {
            if (!IsInstructor())
                return RedirectToAction("Login", "Account");

            // TODO: persist new availability slot once the database layer is wired up.
            return RedirectToAction("Schedule");
        }
    }
}
