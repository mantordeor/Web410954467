using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410954467.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.bruce = 100;
            ViewData["bruce"] = 200;
            return View();
        }
        public ActionResult HW1()
        {
            return View();
        }
        public ActionResult HW2()
        {
            return View();
        }
        public ActionResult HW3()
        {
            return View();
        }
    }
}