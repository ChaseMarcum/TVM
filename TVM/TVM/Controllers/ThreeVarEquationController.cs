using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVM.Controllers
{
    public class ThreeVarEquationController : Controller
    {
        //
        // GET: /ThreeVarEquation/
        public ActionResult Index(int index)
        {
            ViewBag.index = index;
            return View();
        }

        //
        // GET: /ThreeVarEquation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ThreeVarEquation/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ThreeVarEquation/Create
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

        //
        // GET: /ThreeVarEquation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ThreeVarEquation/Edit/5
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

        //
        // GET: /ThreeVarEquation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ThreeVarEquation/Delete/5
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
