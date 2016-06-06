using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PortfolioWebApp.Models;

namespace PortfolioWebApp.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        private PortfolioEntities db = new PortfolioEntities();

        public ActionResult Projects() {
            ViewBag.Message = "Your projects page.";
            return View(db.Projects.ToList());
        }
    }
}