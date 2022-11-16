using BLL;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHunger.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserDTO user) {
            var u = UserService.GetUser(user.Uname);
            if (u != null) {
                if (u.Password.Equals(user.Password)) {
                    var type = u.Type;
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["msg"] = "Username password invalid";
            return RedirectToAction("Index");
            
        }
    }
}