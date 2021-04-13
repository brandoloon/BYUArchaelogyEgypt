using BYUArchaeologyEgypt.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using BYUArchaeologyEgypt.Views.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

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

        // BURIAL VIEWS
        public IActionResult BurialList(string id, int pageNum = 1)
        {
            int pageSize = 5;
            ViewData["locationList"] = _BurialContext.Locations.ToList();
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.HairColors = _BurialContext.Burials.Select(x => x.Hair_color).Distinct().ToList();
            ViewBag.BurialWrapping = _BurialContext.Burials.Select(x => x.Burial_wrapping).Distinct().ToList();
            ViewBag.AgeBracketAtDeath = _BurialContext.Burials.Select(x => x.Age_bracket_at_death).Distinct().ToList();
            ViewBag.Sex = _BurialContext.Burials.Select(x => x.Sex).Distinct().ToList();
            ViewBag.BonesCollected = new List<string> { "True", "False" };


            IQueryable<Burial> query = _BurialContext.Burials;

            if (filters.HasHairColor)
            {
                query = query.Where(t => t.Hair_color == filters.HairColorId);
            }
            if (filters.HasBurialWrapping)
            {
                query = query.Where(t => t.Burial_wrapping == filters.BurialWrapping);
            }
            if (filters.HasAgeBracket)
            {
                query = query.Where(t => t.Age_bracket_at_death == filters.AgeBracketAtDeath);
            }
            if (filters.HasSex)
            {
                query = query.Where(t => t.Sex == filters.Sex);
            }
            if (filters.HasBonesCollected)
            {
                query = query.Where(t => t.Bone_taken == ("true" == filters.BonesCollected) );
            }
            if (filters.HasYearFound)
            {
                query = query.Where(t => t.Year_found.ToString() == filters.YearFound);
            }

            var tasks = query.ToList();

            return View(new BurialListViewModel
            {
                Burials = (query
                .OrderBy(x => x.BurialID)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList()),

                PageNumberingInfo = new PageNumberingInfo
                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,
                    TotalNumItems = query.Count()
                },
                tasks = tasks
            }
                );
        }



        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("BurialList", new { ID = id });
        }
                
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            Burial burial = _BurialContext.Burials.Find(id);
            _BurialContext.Remove(burial);
            _BurialContext.SaveChanges();
            return RedirectToAction("BurialList");
        }


        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Researcher")]
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

        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult Edit(int bid)
        {
            var burial = _BurialContext.Burials.Where(b => b.BurialID == bid).FirstOrDefault();
            ViewData["location"] = _BurialContext.Locations.Where(l => l.LocationId == burial.Location).FirstOrDefault();
            return View(burial);
        }

        [HttpPost]
        [Authorize(Roles = "Researcher")]
        public IActionResult Edit(Burial burial)
        {
            _BurialContext.Burials.Update(burial);
            _BurialContext.SaveChanges();
            return View("Success", burial);
        }

        public IActionResult Details(int bid)
        {
            var burial = _BurialContext.Burials.Where(l => l.BurialID == bid).FirstOrDefault();
            ViewData["img"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.ImgOnSystem).FirstOrDefault();
            ViewData["notes"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.NoteBookOnSystem).FirstOrDefault();
            ViewData["bone"] = _BurialContext.FileOnFileSystemModels.Where(i => i.Id == burial.BoneBookOnSystem).FirstOrDefault();
            return View(burial);
        }

        [Authorize(Roles = "Researcher")]
        public IActionResult Success(Burial burial)
        {
            return View();
        }
        [HttpGet]

        // LOCATION VIEWS
        [HttpGet]
        public IActionResult LocationList()
        {
            return View(_BurialContext.Locations);
        }
        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult LocationCreate()
        {
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Researcher")]
        public IActionResult LocationCreate(Location location)
        {
            var findLocation = _BurialContext.Locations.Where(l =>
                l.HighPairNS == location.HighPairNS &&
                l.LowPairNS == location.LowPairNS &&
                l.BurialLocationNS == location.BurialLocationNS &&
                l.HighPairEW == location.HighPairEW &&
                l.LowPairEW == location.LowPairEW &&
                l.BurialLocationEW == location.BurialLocationEW &&
                l.Subplot == location.Subplot).First();
            if (findLocation == null)
            {
                _BurialContext.Locations.Add(location);
                ViewData["location"] = location;
            }
            else ViewData["location"] = findLocation;
            _BurialContext.SaveChanges();
            return View("Create");
        }
        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult LocationEdit(int lid)
        {
            var location = _BurialContext.Locations.Where(l => l.LocationId == lid).FirstOrDefault();
            return View(location);
        }
        [HttpPost]
        [Authorize(Roles = "Researcher")]
        public IActionResult LocationEdit(Location location)
        {
            _BurialContext.Locations.Add(location);
            _BurialContext.SaveChanges();
            ViewData["location"] = location;
            return View("BurialList");
        }

        // BIOLOGICAL SAMPLE VIEWS
        public IActionResult BiologicalSampleList(int bid)
        {
            return View(_BurialContext.BiologicalSamples.Where(bs => bs.Burial == bid));
        }

        public IActionResult BiologicalSampleDetails(int bsid)
        {
            return View(_BurialContext.BiologicalSamples.Where(bs => bs.SampleId == bsid).FirstOrDefault());
        }

        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult BiologicalSampleCreate(int bid)
        {
            ViewData["burial"] = _BurialContext.Burials.Where(b => b.BurialID == bid).FirstOrDefault();
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Researcher")]
        public IActionResult BiologicalSampleCreate(BiologicalSample biologicalSample)
        {
            _BurialContext.BiologicalSamples.Add(biologicalSample);
            _BurialContext.SaveChanges();
            return View("Success", _BurialContext.Burials.Where(b => b.BurialID == biologicalSample.Burial).FirstOrDefault());
        }

        [HttpGet]
        [Authorize(Roles = "Researcher")]
        public IActionResult BiologicalSampleEdit(int bsid)
        {
            return View(_BurialContext.BiologicalSamples.Where(b => b.SampleId == bsid).FirstOrDefault());
        }
        [HttpPost]
        [Authorize(Roles = "Researcher")]
        public IActionResult BiologicalSampleEdit(BiologicalSample biologicalSample)
        {
            _BurialContext.BiologicalSamples.Add(biologicalSample);
            _BurialContext.SaveChanges();
            return View("Success", _BurialContext.Burials.Where(b => b.BurialID == biologicalSample.Burial).FirstOrDefault());
        }

        // EXTRA VIEWS
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
