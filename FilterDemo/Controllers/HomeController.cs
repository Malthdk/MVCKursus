using FilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace FilterDemo.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.nu = DateTime.Now.ToLongTimeString();
            return View();
        }

        [HttpGet]
        public ActionResult EditPerson()
        {
            string sti = Server.MapPath("~/app_data/person.json");
            Person p;
            if (System.IO.File.Exists(sti))
            {
                string indhold = System.IO.File.ReadAllText(sti);
                p = JsonConvert.DeserializeObject<Person>(indhold);
            }
            else
            {
                p = new Person() { Id = 1 };
            }

            //string sti2 = Server.MapPath("~/app_data/personer.json");
            //List<Person> personer = new List<Person>();
            //personer.Add(new Person() { Id = 1, Navn = "a" });
            //personer.Add(new Person() { Id = 2, Navn = "b" });
            //personer.Add(new Person() { Id = 3, Navn = "c" });
            //string json2 = Newtonsoft.Json.JsonConvert.SerializeObject(personer);
            //System.IO.File.WriteAllText(sti2, json2);
            //List<Person> lst = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>("");

            return View(p);
        }

        [HttpPost]
        public ActionResult EditPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                string json = JsonConvert.SerializeObject(p);
                string path = Server.MapPath("~/app_data/persons.json");
                System.IO.File.WriteAllText(path, json);
            }
           
            return View();
        }
    }
}