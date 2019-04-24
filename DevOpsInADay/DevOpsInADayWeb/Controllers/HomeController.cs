using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DevOpsInADayWeb.Models;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace DevOpsInADayWeb.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            var events = new List<Event>();

            events.Add(new Event
            {
                EventId = 1,
                Name = "DevOps in a Day Irvine",
                Location = @"Microsoft Technology Center
3 Park Plaza Suite 1600
Irvine, CA 92614",
                Date = DateTime.Parse("2019-02-26"),
                Registrants = 40
            });

            events.Add(new Event
            {
                EventId = 2,
                Name = "DevOps in a Day Tampa",
                Location = @"Microsoft Offices
5426 Bay Center Dr.
Suite 700
Tampa, FL 33609",
                Date = DateTime.Parse("2019-03-14"),
                Registrants = 27
            });

            return View(events);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel());
        }
    }
}
