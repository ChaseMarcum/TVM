﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVM.Controllers
{
    public class TwoVarEquationController : Controller
    {
        //
        // GET: /TwoVarEquation/
        public ActionResult Index(int index)
        {
            ViewBag.index = index;
            return View();
        }

       // [HttpPost]

        //public ActionResult Index(int index)
        //{
        //    ViewBag.index = index;
        //    return View();
        //}

        //
        // GET: /TwoVarEquation/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TwoVarEquation/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TwoVarEquation/Create
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
        // GET: /TwoVarEquation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TwoVarEquation/Edit/5
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
        // GET: /TwoVarEquation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TwoVarEquation/Delete/5
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
