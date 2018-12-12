using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}