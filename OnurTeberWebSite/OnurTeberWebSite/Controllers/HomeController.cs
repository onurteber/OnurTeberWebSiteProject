using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnurTeberWebSite.Controllers
{
    public class HomeController : Controller
    {
        // HomePage
        public ActionResult Index()
        {
            return View();
        }
    }
}