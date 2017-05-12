﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeGenerator.DataAccessLayer;

namespace TreeGenerator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DAL dal = new DAL();
            ViewBag.Roots = dal.getRoots(); 



            return View("Home");
        }
    }
}