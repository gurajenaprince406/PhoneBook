﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTask.WebUI.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}