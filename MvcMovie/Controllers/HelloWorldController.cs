using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers {
    public class HelloWorldController : Controller {

        ///
        // GET: /HelloWorld/
        public ActionResult Index() {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/Message/4
        public ActionResult Welcome(string name, int numtimes = 1) {
            ViewBag.Message = name;
            ViewBag.NumTimes = numtimes;
            return View();
        }
    }
}
