using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Portfolio.UI.Controllers
{
    public class AccountController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        // GET: Account
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User p)
        {
            if (userManager.User(p.Email,p.Password))
            {
                FormsAuthentication.SetAuthCookie(p.Email, false);
                Session["Mail"] = p.Email;
                return RedirectToAction("Index", "Home", new { Area = "Dashboard" });
            }
            else
            {
                ViewBag.Error = "Mail veya şifreniz yanlış";
                return View(p);
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return View("Login");
        }
    }
}