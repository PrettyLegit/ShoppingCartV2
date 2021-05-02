/*
 * Course: CS 3410
 * Section: 3
 * Name: Jimmy Nguyen
 * Professor: Alan Shaw
 * Assignment #: Module Assignment #8
 */

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
        string siteHeading = "Beyond The Bath";

        // Text for Order View Heading
        string orderHeading = "The Goods...";

        // Text for View Heading for each Tab
        string[] tabHeadings = { "Home", "Scented Candles", "Bar Soaps", "Hand Soaps",
                                         "Check-Out", "Admin", "About" };

        // View label displayed on each Tab
        string[] tabLabels = { "Home", "Scented Candles", "Bar Soaps", "Hand Soaps",
                                       "Check-Out", "Admin", "About" };

        // View method name for each Tab
        string[] tabViews = { "Index", "Tab1Orders", "Tab2Orders", "Tab3Orders",
                                       "CheckOut", "Admin", "About" };

        // Text for View Heading of any Options columns
        string[] optionsColumnHeading = { "Member Discount", "Have Coupon",
                                              "Post Card", "", "" };

        // The tax rate is 5%
        decimal taxRate = 0.05M;

        // Action Method for Home page View
        public ActionResult Index()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "Welcome To " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/smell_logo.jpg\">";
            ViewBag.Message2 += "<br />Let The Smells Take You Away!";
            return View();
        }

        // Action Method for About page View
        public ActionResult About()
        {
            Session["PageHeading"] = siteHeading;

            ViewBag.Message = "About " + siteHeading;
            ViewBag.Message2 = "<img src=\"/Images/aboutus.jpg\">";
            ViewBag.Message2 += "Developed by Jimmy Nguyen.";
            ViewBag.Message2 += "Disclaimer: this is for educational purposes. All right reserved to to their respective owners.";
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

        // Action Method for Second Product View
        public ActionResult Tab2Orders()
        {
            return GetTabView(2);
        }

        // Action Method to Process Second Product View
        [HttpPost]
        public ActionResult Tab2Orders(string button, FormCollection collection)
        {
            return ProcessTabView(2, button, collection);
        }

        // Action Method for Third Product View
        public ActionResult Tab3Orders()
        {
            return GetTabView(3);
        }

        // Action Method to Process Third Product View
        [HttpPost]
        public ActionResult Tab3Orders(string button, FormCollection collection)
        {
            return ProcessTabView(3, button, collection);
        }

    }
}