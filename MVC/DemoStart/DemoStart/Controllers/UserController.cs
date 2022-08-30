using System.Web.Mvc;

namespace DemoStart.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewData["Message"] = "ViewData Message";
            ViewBag.Message = "ViewBag Message";
            TempData["Message"] = "TempData Message";

            return View();
            //return RedirectToAction("Details","User");
        }

        public ActionResult Details()
        {
            //.......
            //code something .....
            return View();
        }

        public ActionResult Search(string Name)
        {
            ViewBag.Name = Name;
            return View("Details");
        }
    }
}