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
        public async Task<IActionResult> CreateAsync(Burial burial, 
            IFormFile img_file, string img_description,
            IFormFile notes_file, string notes_description,
            IFormFile bone_file, string bone_description)
        {

            // Image Upload
            if (img_file != null)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\Files\\img\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(img_file.FileName);
                var filePath = Path.Combine(basePath, img_file.FileName);
                var extension = Path.GetExtension(img_file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await img_file.CopyToAsync(stream);
                    }
                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = img_file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = img_description,
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
            // Field Notes Upload
            if (notes_file != null)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\Files\\notes\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(notes_file.FileName);
                var filePath = Path.Combine(basePath, notes_file.FileName);
                var extension = Path.GetExtension(notes_file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await notes_file.CopyToAsync(stream);
                    }
                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = notes_file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = notes_description,
                        FilePath = filePath
                    };
                    _BurialContext.FileOnFileSystemModels.Add(fileModel);
                    _BurialContext.SaveChanges();
                    burial.NoteBookOnSystem = _BurialContext.FileOnFileSystemModels.Where(f => f.FilePath == fileModel.FilePath).FirstOrDefault().Id;
                }
                else
                {
                    ViewBag.status = "Photo already esists with this name and file type";
                    return View();
                }
            }
            // Bone Book Upload
            if (img_file != null)
            {
                var basePath = Path.Combine(Directory.GetCurrentDirectory() + "\\wwwroot\\Files\\bonebooks\\");
                bool basePathExists = System.IO.Directory.Exists(basePath);
                if (!basePathExists) Directory.CreateDirectory(basePath);
                var fileName = Path.GetFileNameWithoutExtension(bone_file.FileName);
                var filePath = Path.Combine(basePath, bone_file.FileName);
                var extension = Path.GetExtension(bone_file.FileName);
                if (!System.IO.File.Exists(filePath))
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await bone_file.CopyToAsync(stream);
                    }
                    var fileModel = new FileOnFileSystemModel
                    {
                        CreatedOn = DateTime.UtcNow,
                        FileType = bone_file.ContentType,
                        Extension = extension,
                        Name = fileName,
                        Description = bone_description,
                        FilePath = filePath
                    };
                    _BurialContext.FileOnFileSystemModels.Add(fileModel);
                    _BurialContext.SaveChanges();
                    burial.BoneBookOnSystem = _BurialContext.FileOnFileSystemModels.Where(f => f.FilePath == fileModel.FilePath).FirstOrDefault().Id;
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
            ViewData["notes"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.NoteBookOnSystem).FirstOrDefault();
            ViewData["bone"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.BoneBookOnSystem).FirstOrDefault();
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
