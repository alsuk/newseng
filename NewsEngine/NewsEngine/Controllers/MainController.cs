using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsEngine.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult Author ()
        {
            return View();
        }
        public ViewResult RazorTest()
        {
            return View();
        }
    }
}