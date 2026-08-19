using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class ManagerController : Controller
    {
        private bool IsManager()
        {
            return Session["Role"] as string == "Manager";
        }

        public ActionResult Index()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return RedirectToAction("Bookings");
        }

        public ActionResult Bookings()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Students()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Staff()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Instructors()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Vehicles()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Reports()
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(string FullName, string Email, string Phone, string Role)
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            // TODO: persist new staff member once the database layer is wired up.
            return RedirectToAction("Staff");
        }

        [HttpPost]
        public ActionResult AddStudent(string FullName, string Email, string Phone, string IdNumber)
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            // TODO: persist new student once the database layer is wired up.
            return RedirectToAction("Students");
        }

        [HttpPost]
        public ActionResult AddBooking(string StudentName, string InstructorName, string BookingDate, string BookingTime)
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            // TODO: persist new booking once the database layer is wired up.
            return RedirectToAction("Bookings");
        }

        [HttpPost]
        public ActionResult AddInstructor(string FullName, string Email, string Phone, string AssignedVehicle)
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            // TODO: persist new instructor once the database layer is wired up.
            return RedirectToAction("Instructors");
        }

        [HttpPost]
        public ActionResult AddVehicle(string Make, string Model, string Registration, string AssignedInstructor)
        {
            if (!IsManager())
                return RedirectToAction("Login", "Account");

            // TODO: persist new vehicle once the database layer is wired up.
            return RedirectToAction("Vehicles");
        }
    }
}