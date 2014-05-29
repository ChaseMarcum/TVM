using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVM.Models;

namespace TVM.Controllers
{
    public class DivideByTwoController : Controller
    {
        //
        // GET: /DivideByTwo/
        public ActionResult Index()
        {
            DivideByTwo function = new DivideByTwo();
            return View(function);
        }
	}
}