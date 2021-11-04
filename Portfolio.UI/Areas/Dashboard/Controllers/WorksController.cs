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
    public class WorksController : Controller
    {
        WorkManager workManager = new WorkManager(new EfWorkRepository());
        // GET: Dashboard/Works
        public ActionResult Index()
        {
            return View(workManager.List());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create(Work p)
        {
            p.IsActive = true;
            p.IsActive = DateTime.Now;
            workManager.Add(p);
            return RedirectToAction("Index");
        }
    }
}