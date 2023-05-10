using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";



            return View();
        }

        public ActionResult Contact(int number)
        {
            ViewBag.Message = number;

            return View();
        }
    }
}