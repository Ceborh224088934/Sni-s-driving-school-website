using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class ManagerController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Role"] as string != "Manager")
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}