using Portfolio.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Controllers
{
    public class HomeController : Controller
    {
        Slider slider = new Slider();
        // GET: Home
        public ActionResult Index()
        {
            return View(slider);
        }
    }
}