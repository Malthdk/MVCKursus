using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        [Route("~/")]
        public ActionResult Index()
        {
            List<string> tmp = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                tmp.Add(Guid.NewGuid().ToString());
            }
            return View(tmp);
        }

        [HttpGet]
        [Route("~/Test")]
        public ActionResult Test()
        {
            Person p = new Person() { Alder = 28, ErILive = true, Navn = "Malte"};
            return View(p);
        }
    }
}