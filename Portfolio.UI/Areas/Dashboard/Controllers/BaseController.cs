using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Areas.Dashboard.Controllers
{
    public class BaseController : Controller
    {
        public int Id { get; set; }
        public string Mail { get; set; }

        UserManager userManager = new UserManager(new EfUserRepository());
        // GET: Dashboard/Base
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Header()
        { return View(SignIn()); }

        public ActionResult Navbar()
        {
            return View();
        }

        public User SignIn()
        {
            Mail = Session["Mail"].ToString();
            var user = userManager.Get(x => x.Email == Mail);
            return user;
        }
    }
}