using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult Liste()
        {
            return PartialView();
        }

        [HttpGet]
        [ChildActionOnly]
        public ActionResult Liste2(int antal = 10)
        {
            try
            {
                List<string> lst = new List<string>();

                for (int i = 0; i < antal; i++)
                {
                    lst.Add(Guid.NewGuid().ToString());
                }

                return PartialView(lst);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Error");
            }
        }

        [HttpGet]
        public ActionResult Error()
        {
           return View();
        }
    }
}