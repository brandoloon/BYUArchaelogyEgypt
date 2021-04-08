using BYUArchaeologyEgypt.Models;
using BYUArchaeologyEgypt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BYUArchaeologyEgypt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BurialContext _BurialContext { get; set; }

        public HomeController(ILogger<HomeController> logger, BurialContext burialContext)
        {
            _logger = logger;
            _BurialContext = burialContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List() 
        {
            return View(_BurialContext.Burials);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Burial burial)
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
