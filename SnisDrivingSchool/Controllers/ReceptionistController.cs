using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class ReceptionistController : Controller
    {
        private bool IsReceptionist()
        {
            return Session["Role"] as string == "Receptionist";
        }

        public ActionResult Index()
        {
            if (!IsReceptionist())
                return RedirectToAction("Login", "Account");

            return RedirectToAction("Bookings");
        }

        public ActionResult Bookings()
        {
            if (!IsReceptionist())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Students()
        {
            if (!IsReceptionist())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        public ActionResult AddBooking(string StudentName, string InstructorName, string BookingDate, string BookingTime)
        {
            if (!IsReceptionist())
                return RedirectToAction("Login", "Account");

            // TODO: persist new booking once the database layer is wired up.
            return RedirectToAction("Bookings");
        }

        [HttpPost]
        public ActionResult AddStudent(string FullName, string Email, string Phone, string IdNumber)
        {
            if (!IsReceptionist())
                return RedirectToAction("Login", "Account");

            // TODO: persist new student once the database layer is wired up.
            return RedirectToAction("Students");
        }
    }
}
