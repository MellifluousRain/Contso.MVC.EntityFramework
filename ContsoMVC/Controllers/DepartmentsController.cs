using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contso.Data;
using Contso.Model;
using Contso.Service;

namespace ContsoMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public DepartmentService departmentService = new DepartmentService();
        // GET: Departments
        public ActionResult Index()
        {
            return View(departmentService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Departments dep)
        {
            //Contso.Data.ContsoMVC db = new Contso.Data.ContsoMVC();
            //ViewBag.Instructorid = new SelectList(db.Instructor, "id", "id");
            departmentService.Create(dep);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id) // When directing to this page **************
        {
            return View(departmentService.GetById(Id));
        }

        [HttpPost]
        public ActionResult Edit(Departments department) // When clicking Submit on this page ***********
        {
            departmentService.Update(department);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(departmentService.GetById(id));
        }

        public ActionResult Delete(int id)
        {
            departmentService.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}