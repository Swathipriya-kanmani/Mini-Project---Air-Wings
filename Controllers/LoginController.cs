using AirlinesProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AirlinesProject.Controllers
{
    public class LoginController : Controller
    {
        private readonly WebsiteAirlineContext db;
        private readonly ISession session;

        public LoginController(WebsiteAirlineContext _db)  //constructor
        {
            db = _db;
            

        }



        [HttpGet]
        public IActionResult login()
        {
            //UserLogin emp = UserLogin.GetSingleEmployeeInfo();
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLogin l)
        {
            var result = (from i in db.UserLogins
                          where i.UserName == l.UserName && i.Password == l.Password
                          select i).SingleOrDefault();
            if (result != null)
            {
                //HttpContext.Session.SetString("username", l.UserName);
                return RedirectToAction("Details", "User");
            }

            return null;

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(UserLogin l)
        {
            db.UserLogins.Add(l);
            db.SaveChanges();
            return RedirectToAction("login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("login");
        }
    }
}
