using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoGreen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string surname)
        {
            ViewBag.Name = name;
            ViewBag.Surname = surname;
            return View("Login", surname as object);
        }

        public ActionResult Login(string surname)
        {
            ViewBag.Surname = surname;

            return View();
        }
        [HttpPost]
        public ActionResult Login(string surname, string email)
        {
            ViewBag.Surname= surname;
            return View("Trip");
        }

        public ActionResult Trip()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Trip(string from, string to)
        {
            ViewBag.From = from;
            ViewBag.To = to;
            return View("TripResult");
        }

        public ActionResult TripResult()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult TripResult(string trip)
        {
            ViewBag.Trip = trip;
            return View("ChosenTrip");
        }

        public ActionResult Chosentrip()
        {

            return View();
        }

        public ActionResult Badges()
        {

            return View();
        }
    }
}