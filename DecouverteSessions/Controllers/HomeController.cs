using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DecouverteSessions.Models;
using Microsoft.AspNetCore.Http;

namespace DecouverteSessions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            this.HttpContext.Session.SetString("Ticks", DateTime.Now.Ticks.ToString());

            this.ViewBag.Message = this.HttpContext.Session.GetString("Ticks");

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Message"] = this.HttpContext.Session.GetString("Ticks");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
