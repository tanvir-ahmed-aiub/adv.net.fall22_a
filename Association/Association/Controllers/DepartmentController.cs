using Association.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Association.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            UMS_fall22_aEntities db = new UMS_fall22_aEntities();

            return View(db.Departments.ToList());
        }
        public ActionResult Details(int id)
        {
            UMS_fall22_aEntities db = new UMS_fall22_aEntities();
            var d = (from dept in db.Departments
                     where dept.Id == id
                     select dept).SingleOrDefault();
            //var students = (from student in db.Students
            //                where student.DepartmentId == id
            //                select student).ToList();
            //ViewBag.Students = students;
            //var courses = (from c in db.Courses
            //               where c.DepartmentId == id
            //               select c).ToList();
            //ViewBag.Courses = courses;
            return View(d);
        }

    }
}