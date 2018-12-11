using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Test()
        {
            return Content("1;2;3", "application/CSV");
        }
        public ActionResult RedirectTest()
        {
            return RedirectToAction("Index");
        }
        public ActionResult JsonTest()
        {
            return Json(Person.Personer(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewTest()
        {
            return View();
        }

        public ActionResult RenderViewTest()
        {
            RenderViewModel m = new RenderViewModel
            {
                Id = 1,
                Streng = Guid.NewGuid().ToString()
            };

            return View(m);
        }

        public ActionResult Test10(string test, int tal = 0)
        {
            return View();
        }

        public ActionResult Test11(Person p)
        {
            return View();
        }

        public ActionResult Test12(Person p)
        {
            if (ModelState.IsValid)
                Console.WriteLine("Its not valid! :(");
            else
                Console.WriteLine("Its not valid! :(");
            return View();
        }
    }

    public class RenderViewModel {
        public int Id { get; set; }
        public string Streng { get; set; }
    }


    public class Person {
        public int Id { get; set; }
        public int Alder { get; set; }
        public string Navn { get; set; }

        public static List<Person> Personer()
        {
            List<Person> p = new List<Person>()
            {
                new Person(){ Id=1, Alder = 20, Navn = "asdf"},
                new Person(){ Id=2, Alder = 30, Navn = "sdfdfsghegsgd"},
                new Person(){ Id=3, Alder = 40, Navn = "dæflkgj lsdfkj lsdfkj dlsj"}
            };
            return p;
        }
    }


    public class UnitTest
    {
        public void TestMetode()
        {
            HomeController c = new HomeController();
            ViewResult r = c.Index() as ViewResult;
            var s = r.Model as List<string>;
            if (s.Count == 5) { } else { }
        }
    }
}