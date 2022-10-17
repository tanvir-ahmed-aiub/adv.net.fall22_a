using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            UMS_fall22_aEntities db = new UMS_fall22_aEntities();
            return View(db.Courses.ToList());
        }
        [HttpPost]
        public ActionResult Index(int[] courses)
        {
            UMS_fall22_aEntities db = new UMS_fall22_aEntities();
            foreach (var course in courses) {
                db.CourseStudents.Add(new CourseStudent()
                {
                    CourseId = course,
                    StudentId = 2
                });

            }
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}