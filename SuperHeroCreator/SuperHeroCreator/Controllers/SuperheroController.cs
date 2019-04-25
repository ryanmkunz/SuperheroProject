using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroCreator.Controllers
{
    public class SuperheroController : Controller
    {
        // GET: Bacon
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bacon/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bacon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bacon/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bacon/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bacon/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Bacon/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bacon/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
