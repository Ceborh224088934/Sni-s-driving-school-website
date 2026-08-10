using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class AdminStaffController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Role"] as string != "AdminStaff")
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}