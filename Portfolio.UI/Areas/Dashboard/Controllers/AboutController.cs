using FluentValidation.Results;
using Portfolio.BLL.Concrete;
using Portfolio.BLL.ValidationRules;
using Portfolio.DAL.EntityFramework;
using Portfolio.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.UI.Areas.Dashboard.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        AboutValidator aboutValidator = new AboutValidator();
        // GET: Dashboard/About
        public ActionResult Index()
        {
            return View(aboutManager.List());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(About p)
        {
            ValidationResult validationResult = aboutValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.IsActive = true;
                p.CreateDate = DateTime.Now;
                aboutManager.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(p);
            }
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(aboutManager.Get());
        }

        [HttpPost]
        public ActionResult Edit(About p)
        {
            ValidationResult validationResult = aboutValidator.Validate(p);
            if (validationResult.IsValid)
            {
                var key = aboutManager.Get();
                p.IsActive = key.IsActive;
                p.CreateDate = key.CreateDate;
                aboutManager.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(p);
            }
        }
    }
}