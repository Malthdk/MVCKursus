﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteDemo.Controllers
{
    public class AppController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Salg()
        {
            return View();
        }

        public ActionResult Error(string q)
        {
            return View();
        }
    }
}