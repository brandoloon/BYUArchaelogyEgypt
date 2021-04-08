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
        private ApplicationDbContext _context;
        private BurialContext _BurialContext { get; set; }

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, BurialContext burialContext)
        {
            _logger = logger;
            _context = context;
            _BurialContext = burialContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BurialList()
        {
            return View(_context);
        }

        public IActionResult List() 
        {
            return View(_BurialContext.Burials);
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
