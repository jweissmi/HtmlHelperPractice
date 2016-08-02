using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HtmlHelperPractice.Models;

namespace HtmlHelperPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your Application Description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(ContactInfo.GetContactInfo());
        }

        public ActionResult ContactList()
        {
            ViewBag.Message = "Your Contact List Page.";

            return View(ContactInfo.GetContactList());
        }
    }
}