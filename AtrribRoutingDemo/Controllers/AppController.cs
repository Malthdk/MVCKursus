using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AtrribRoutingDemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        [Route("~/")]
        [Route("~/home")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("~/Salg/{kundeid:int}")]
        public ActionResult Salg(int kundeid)
        {
            ViewBag.kundeid = kundeid;
            return View();
        }
    }
}