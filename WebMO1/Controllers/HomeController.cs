using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMO1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About time someone looked at this!  MO 16:22";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Michael O'Flaherty";

            return View();
        }
    }
}