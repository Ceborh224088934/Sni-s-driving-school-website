
using System.Web.Mvc;

namespace SnisDrivingSchool.Controllers
{
    public class StudentController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["Role"] == null || Session["Role"].ToString() != "Student")
            {
                filterContext.Result = RedirectToAction("Login", "Account");
            }
            base.OnActionExecuting(filterContext);
        }

        public ActionResult Index()
        {
            ViewBag.Username = Session["Username"];
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }

        public ActionResult Bookings()
        {
            return View();
        }

        public ActionResult RateAndReviews()
        {
            return View();
        }
    }
}