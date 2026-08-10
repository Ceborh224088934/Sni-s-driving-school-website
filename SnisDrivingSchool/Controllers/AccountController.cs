using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ViewBag.Error = "Please enter both username and password.";
                return View();
            }

            username = username.ToLower().Trim();

            if (password != "12345")
            {
                ViewBag.Error = "Invalid username or password.";
                return View();
            }

            switch (username)
            {
                case "manager":
                    Session["Role"] = "Manager";
                    return RedirectToAction("Index", "Manager");
                case "receptionist":
                    Session["Role"] = "Receptionist";
                    return RedirectToAction("Index", "Receptionist");
                case "instructor":
                    Session["Role"] = "Instructor";
                    return RedirectToAction("Index", "Instructor");
                case "student":
                    Session["Role"] = "Student";
                    return RedirectToAction("Index", "Student");
                case "adminstaff":
                    Session["Role"] = "AdminStaff";
                    return RedirectToAction("Index", "AdminStaff");
                default:
                    ViewBag.Error = "Invalid username or password.";
                    return View();
            }
        }

        // GET: Account/Register (placeholder for now)
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}