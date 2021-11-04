using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
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
        BackgroundManager backgroundManager = new BackgroundManager(
            new EfBackgroundRepository(),
            new EfDegreeRepository());
        Slider slider = new Slider();
        // GET: Home
        public ActionResult Index()
        {
            slider.Background = backgroundManager.Get();
            slider.Degree = backgroundManager.ListDegree();
            return View(slider);
        }
    }
}