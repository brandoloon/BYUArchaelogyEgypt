using BYUArchaeologyEgypt.Models;
using BYUArchaeologyEgypt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

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

        public IActionResult BurialList() 
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Burial burial, List<IFormFile> files, string description)
        {

            
            foreach (var file in files)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\img\\Files\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var filePath = Path.Combine(basePath, file.FileName);
                var extension = Path.GetExtension(file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = description,
                        FilePath = filePath
                    };
                    _BurialContext.FileOnFileSystemModels.Add(fileModel);
                    _BurialContext.SaveChanges();
                    burial.ImgOnSystem = _BurialContext.FileOnFileSystemModels.Where(f => f.FilePath == fileModel.FilePath).FirstOrDefault().Id;
                }
                else
                {
                    ViewBag.status = "Photo already esists with this name and file type";
                    return View();
                }
            }
            _BurialContext.Burials.Add(burial);
            _BurialContext.SaveChanges();
            return View("Success", burial);
        }
        public IActionResult Success(Burial burial)
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(int bid)
        {
            var burial = _BurialContext.Burials.Where(l => l.BurialID == bid).FirstOrDefault();
            ViewData["img"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.ImgOnSystem).FirstOrDefault();
            return View(burial);
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
