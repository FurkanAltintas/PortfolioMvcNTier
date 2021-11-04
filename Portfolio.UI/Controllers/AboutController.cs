using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        // GET: About
        public ActionResult Index()
        {
            return View(aboutManager.Get());
        }
    }
}