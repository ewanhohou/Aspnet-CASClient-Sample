﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspnet.Mvc.CASClient.Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Logout()
        {
            DotNetCasClient.CasAuthentication.ClearAuthCookie();

            return RedirectToAction("Index");
        }

        [Authorize]
        public ActionResult Secrete()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}