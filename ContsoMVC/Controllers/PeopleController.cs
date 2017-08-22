using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contso.Model;
using Contso.Service;

namespace ContsoMVC.Controllers
{
    public class PeopleController : Controller
    {
        PeopleService peopleService = new PeopleService();
        // GET: People
        public ActionResult Index()
        {
            return View(peopleService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(People people)
        {
            peopleService.Create(people);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(peopleService.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(People people)
        {
            peopleService.Update(people);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            return View(peopleService.GetById(id));
        }

        public ActionResult Delete(int id)
        {
            peopleService.DeleteById(id);
            return RedirectToAction("Index");
        }
    }
}