using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10_12_Intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {

            string navn = "MalteLH";

            return Json(navn, JsonRequestBehavior.AllowGet);
        }
    }
}