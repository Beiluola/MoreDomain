﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MoreDomain.UI.Portal.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            var t =RouteData;
            return Json(t,JsonRequestBehavior.AllowGet);
            return Content("1");
        }
    }
}