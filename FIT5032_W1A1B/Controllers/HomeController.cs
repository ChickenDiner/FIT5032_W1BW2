using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_W1A1B.Models.HelloWorld;

namespace FIT5032_W1A1B.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Example() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}