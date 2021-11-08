using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Areas.Dashboard.Controllers
{
    public class BackgroundController : Controller
    {
        BackgroundManager backgroundManager = new BackgroundManager
            (
            new EfBackgroundRepository(),
            new EfDegreeRepository()
            );
        // GET: Dashboard/Background
        public ActionResult Index()
        {
            return View(backgroundManager.Get());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}