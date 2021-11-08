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
    public class DegreeController : Controller
    {
        DegreeManager degreeManager = new DegreeManager(new EfDegreeRepository());
        DegreeValidator degreeValidator = new DegreeValidator();
        // GET: Dashboard/Degree
        public ActionResult Index()
        {
            return View(degreeManager.List());
        }

        [HttpGet]
        public PartialViewResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Create(Degree p)
        {
            ValidationResult validationResult = degreeValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.IsActive = true;
                p.CreateDate = DateTime.Now;
                degreeManager.Add(p);
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
        public ActionResult Edit(int id)
        {
            return View(degreeManager.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Degree p)
        {
            ValidationResult validationResult = degreeValidator.Validate(p);
            if (validationResult.IsValid)
            {
                var key = degreeManager.Get(p.Id);
                p.IsActive = key.IsActive;
                p.CreateDate = key.CreateDate;
                degreeManager.Update(p);
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

        public ActionResult Delete(int id)
        {
            degreeManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}