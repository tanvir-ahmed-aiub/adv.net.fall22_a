using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Section = "B";
            ViewData["Course"] = "Adv .Net";
            return View();
        }
        public ActionResult Projects() {
            //return Redirect("https://www.aiub.edu");
            return View("Index");
            //return RedirectToAction("About", "Home");
            //return RedirectToAction("Index");
        }
        
    }
}