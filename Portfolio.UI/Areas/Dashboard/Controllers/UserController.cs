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
    public class UserController : Controller
    {
        AuthorityManager authorityManager = new AuthorityManager(new EfAuthorityRepository());
        UserManager userManager = new UserManager(new EfUserRepository());
        UserValidator userValidator = new UserValidator();
        // GET: Dashboard/User
        public ActionResult Index()
        { return View(userManager.List()); }

        [HttpGet]
        public ActionResult Create()
        { Authority(); return View(); }

        [HttpPost]
        public ActionResult Create(User p)
        {
            ValidationResult validationResult = userValidator.Validate(p);
            if (validationResult.IsValid)
            {
                p.CreateDate = DateTime.Now;
                p.IsActive = true;
                userManager.Add(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                Authority();
                return View(p);
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        { return View(authorityManager.Get(id)); }

        [HttpPost]
        public ActionResult Edit(int id, User p)
        {
            ValidationResult validationResult = userValidator.Validate(p);
            if (validationResult.IsValid)
            {
                var key = authorityManager.Get(id);
                p.IsActive = key.IsActive;
                p.CreateDate = key.CreateDate;
                userManager.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                Authority();
                return View(p);
            }
        }

        public ActionResult Delete(int id)
        { authorityManager.Delete(id); return RedirectToAction("Index"); }

        public void Authority()
        { ViewBag.Authority = new SelectList(authorityManager.List(), "Id", "Name"); }
    }
}