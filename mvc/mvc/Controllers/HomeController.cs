using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;


namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        [CustomActionFilter]
        public ActionResult Index()
        {
            Employee e = new Employee() { firstname = "Vishnu", lastname = "Vardhan", address = "INDIA" };
            return View(e);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult View1()
        {
            ViewBag.Message = "Employee creation page.";

            return View();
        }
    }
}