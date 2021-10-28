using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Ruiz.DAL;
using Ruiz.Helpers;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin,Editor")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Sliders.Count() / 2d);

            List<Slider> sliders = _context.Sliders
                 .Skip((page - 1) * 2).Take(2)
                .ToList();

            return View(sliders);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Slider slider)
        {
          

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View();
                }
                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View();
                }


                slider.BgImage = FileManager.Save(_env.WebRootPath, "uploads/sliders", slider.ImageFile);

            }



            _context.Sliders.Add(slider);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Slider slider = _context.Sliders.FirstOrDefault(x => x.Id == id);

            if (slider == null) return RedirectToAction("error", "home");

            return View(slider);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Slider slider)
        {
            if (!ModelState.IsValid) return View();

            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == slider.Id);

            if (existSlider == null) return RedirectToAction("error", "home");

            existSlider.Title = slider.Title;
            existSlider.Content = slider.Content;
            existSlider.SubTitle = slider.SubTitle;
            existSlider.SubTitle2 = slider.SubTitle2;
            existSlider.Order = slider.Order;
            existSlider.RedirectUrl = slider.RedirectUrl;
            existSlider.BtnText = slider.BtnText;

            if (slider.ImageFile != null)
            {
                if (slider.ImageFile.ContentType != "image/jpeg" && slider.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View();
                }

                if (slider.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View();
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/sliders", slider.ImageFile);

                if (!string.IsNullOrWhiteSpace(existSlider.BgImage))
                {
                    string oldPath = Path.Combine(_env.WebRootPath, "uploads/sliders", existSlider.BgImage);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                existSlider.BgImage = newFileName;
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Slider existSlider = _context.Sliders.FirstOrDefault(x => x.Id == id);
            if (existSlider == null)
            {
                return Json(new { status = 404 });
            }
            if (!string.IsNullOrWhiteSpace(existSlider.BgImage))
            {
                FileManager.Delete(_env.WebRootPath, "uploads/sliders", existSlider.BgImage);
            }

            _context.Sliders.Remove(existSlider);
            _context.SaveChanges();

            return Json(new { status = 200 });
        }
    }
}
