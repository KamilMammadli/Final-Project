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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TestimonialController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Testimonials.Count() / 3d);

            List<Testimonial> testimon = _context.Testimonials
                 .Skip((page - 1) * 3).Take(3)
                .ToList();

            return View(testimon);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Testimonial testimon)
        {


            if (testimon.ImageFile != null)
            {
                if (testimon.ImageFile.ContentType != "image/jpeg" && testimon.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View();
                }
                if (testimon.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View();
                }


                testimon.Image = FileManager.Save(_env.WebRootPath, "assets/images/testimonial", testimon.ImageFile);

            }



            _context.Testimonials.Add(testimon);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Testimonial testimon = _context.Testimonials.FirstOrDefault(x => x.Id == id);

            if (testimon == null) return RedirectToAction("error", "home");

            return View(testimon);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Testimonial testimon)
        {
            if (!ModelState.IsValid) return View();

            Testimonial existtestimon = _context.Testimonials.FirstOrDefault(x => x.Id == testimon.Id);

            if (existtestimon == null) return RedirectToAction("error", "home");

            existtestimon.FullName = testimon.FullName;
            existtestimon.Position = testimon.Position;
            existtestimon.Text = testimon.Text;
            if (testimon.ImageFile != null)
            {
                if (testimon.ImageFile.ContentType != "image/jpeg" && testimon.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View(testimon);
                }

                if (testimon.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View(testimon);
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "assets/images/testimonial", testimon.ImageFile);

                if (!string.IsNullOrWhiteSpace(existtestimon.Image))
                {
                    string oldPath = Path.Combine(_env.WebRootPath, "assets/images/testimonial", existtestimon.Image);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                existtestimon.Image = newFileName;
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Testimonial existtestimon = _context.Testimonials.FirstOrDefault(x => x.Id == id);
            if (existtestimon == null)
            {
                return Json(new { status = 404 });
            }
            if (!string.IsNullOrWhiteSpace(existtestimon.Image))
            {
                FileManager.Delete(_env.WebRootPath, "assets/images//testimonial", existtestimon.Image);
            }

            _context.Testimonials.Remove(existtestimon);
            _context.SaveChanges();

            return Json(new { status = 200 });
        }
    }
}
