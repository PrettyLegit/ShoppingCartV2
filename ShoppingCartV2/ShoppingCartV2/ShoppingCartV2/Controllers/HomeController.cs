using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCartV2.Models;

namespace ShoppingCartV2.Controllers
{
    public partial class HomeController : Controller
    {
        // Text for Site Heading
        string siteHeading = "The Fun Cake Store";

        // Text for Order View Heading
        string orderHeading = "Cake Orders";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Single Layer Cake",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "1-Layer",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "", "Single Layer Options",
                                              "", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/logo.jpg\">";
            ViewBag.Message2 += "<br />This is the Cake Store of your Dreams!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "Modify this to identify yourself as the Webmaster.";
            return View();
        }

        // Action Method for First Product View
        public ActionResult Tab1Orders()
        {
            return GetTabView(1);
        }

        // Action Method to Process First Product View
        [HttpPost]
        public ActionResult Tab1Orders(string button, FormCollection collection)
        {
            return ProcessTabView(1, button, collection);
        }

    }
}