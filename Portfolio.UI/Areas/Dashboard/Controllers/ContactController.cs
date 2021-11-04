using Portfolio.BLL.Concrete;
using Portfolio.DAL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Areas.Dashboard.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(
            new EfContactRepository(),
            new EfInformationRepository());
        // GET: Dashboard/Contact
        public ActionResult Index()
        {
            return View(contactManager.List());
        }
    }
}