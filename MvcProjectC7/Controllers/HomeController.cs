using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectC7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return Content("Hello from Index");
        }

        [ActionName("About")]
        public ActionResult SomeMethodName()
        {
            return View();
        }
    }
}