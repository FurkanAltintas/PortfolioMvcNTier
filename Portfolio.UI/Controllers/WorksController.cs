using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Controllers
{
    public class WorksController : Controller
    {
        WorkManager workManager = new WorkManager(new EfWorkRepository());
        // GET: Work
        public ActionResult Index()
        {
            return View(workManager.List());
        }

        public ActionResult Detail(int id, string filter)
        {
            TempData["Id"] = id;
            return View(workManager.Get(id));
        }

        public PartialViewResult List()
        {
            ViewBag.Id = TempData["Id"];
            return PartialView(workManager.List().Take(6).ToList());
        }
    }
}