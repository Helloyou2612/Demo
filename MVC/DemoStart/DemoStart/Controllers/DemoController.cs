using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoStart.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Noti = "Hello MVC";
            return View();
        }

        // POST: Demo
        [HttpPost]
        public ActionResult Index(string id)
        {
            ViewBag.Noti = "Hello MVC";
            return View();
        }

        public ActionResult Details(string Id)
        {
            ViewBag.Noti = $"Details Id = {Id}";
            return View("Index");
        } 
    }
}