using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository(),
                                                           new EfInformationRepository());
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact p)
        {
            p.IsActive = true;
            p.CreateDate = DateTime.Now;
            contactManager.Add(p);
            return RedirectToAction("Index");
        }

        public PartialViewResult Address()
        {
            return PartialView(contactManager.GetAddress());
        }
    }
}