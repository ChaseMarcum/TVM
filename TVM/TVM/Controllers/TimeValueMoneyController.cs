using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVM.Controllers
{
    public class TimeValueMoneyController : Controller
    {
        //
        // GET: /TimeValueMoney/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /TimeValueMoney/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TimeValueMoney/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TimeValueMoney/Create
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
        // GET: /TimeValueMoney/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TimeValueMoney/Edit/5
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
        // GET: /TimeValueMoney/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TimeValueMoney/Delete/5
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
