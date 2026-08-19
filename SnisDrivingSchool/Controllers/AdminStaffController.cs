using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class AdminStaffController : Controller
    {
        private bool IsAdminStaff()
        {
            return Session["Role"] as string == "AdminStaff";
        }

        public ActionResult Index()
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            return RedirectToAction("Staff");
        }

        public ActionResult Staff()
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Students()
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            return View();
        }

        public ActionResult Reports()
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            return View();
        }

        [HttpPost]
        public ActionResult AddStaff(string FullName, string Email, string Phone, string Role)
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            // TODO: persist new staff member once the database layer is wired up.
            return RedirectToAction("Staff");
        }

        [HttpPost]
        public ActionResult AddStudent(string FullName, string Email, string Phone, string IdNumber)
        {
            if (!IsAdminStaff())
                return RedirectToAction("Login", "Account");

            // TODO: persist new student once the database layer is wired up.
            return RedirectToAction("Students");
        }
    }
}
