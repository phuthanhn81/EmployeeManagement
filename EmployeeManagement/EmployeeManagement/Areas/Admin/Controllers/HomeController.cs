using System.Web.Mvc;

namespace EmployeeManagement.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult Topbar()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}