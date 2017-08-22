using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contso.Model;
using Contso.Service;

namespace ContsoMVC.Controllers
{
    public class CoursesController : Controller
    {
        CoursesService coursesService = new CoursesService();
        // GET: Courses
        public ActionResult Index()
        {
            return View(coursesService.GetAll());
        }

        public ActionResult Edit(int id)
        {
            return View(coursesService.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Courses course)
        {
            coursesService.Update(course);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses course)
        {
            coursesService.Create(course);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(coursesService.GetById(id));
        }

        public ActionResult Delete(int id)
        {
            coursesService.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}