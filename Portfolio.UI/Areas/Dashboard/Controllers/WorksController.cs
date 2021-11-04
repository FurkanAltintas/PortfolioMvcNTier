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
        public ActionResult Edit(int id)
        {
            return View(Get(id));
        }

        [HttpPost]
        public ActionResult Process(Work p)
        {
            if (p.Id > 0)
            {
                var key = Get(p.Id);
                p.CreateDate = key.CreateDate;
                p.IsActive = key.IsActive;
                workManager.Update(p);
            }
            else
            {
                p.IsActive = true;
                p.CreateDate = DateTime.Now;
                workManager.Add(p);
            }
            return RedirectToAction("Index");
        }

        public Work Get(int id)
        {
            return workManager.Get(id);
        }
    }
}