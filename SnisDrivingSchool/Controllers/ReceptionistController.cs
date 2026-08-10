using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class ReceptionistController : Controller
    {
        public ActionResult Index()
        {
            if (Session["Role"] as string != "Receptionist")
                return RedirectToAction("Login", "Account");

            return View();
        }
    }
}