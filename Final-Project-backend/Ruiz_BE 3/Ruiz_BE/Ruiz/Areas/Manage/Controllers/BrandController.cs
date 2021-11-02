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
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BrandController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Brands.Count() / 4d);

            List<Brand> brands = _context.Brands
                 .Skip((page - 1) * 4).Take(4)
                .ToList();

            return View(brands);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Brand brand)
        {
            if (brand.ImageFile != null)
            {
                if (brand.ImageFile.ContentType != "image/jpeg" && brand.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View(brand);
                }
                if (brand.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View(brand);
                }


                brand.Image = FileManager.Save(_env.WebRootPath, "assets/images/brand", brand.ImageFile);

            }

            _context.Brands.Add(brand);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Brand brand = _context.Brands.FirstOrDefault(x => x.Id == id);

            if (brand == null) return RedirectToAction("error", "home");

            return View(brand);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Brand brand)
        {
            if (!ModelState.IsValid) return View();

            Brand existbrand = _context.Brands.FirstOrDefault(x => x.Id == brand.Id);

            if (existbrand == null) return RedirectToAction("error", "home");

            existbrand.Name = brand.Name;

            if (brand.ImageFile != null)
            {
                if (brand.ImageFile.ContentType != "image/jpeg" && brand.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                    return View();
                }

                if (brand.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                    return View();
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "assets/images/brand", brand.ImageFile);

                if (!string.IsNullOrWhiteSpace(existbrand.Image))
                {
                    string oldPath = Path.Combine(_env.WebRootPath, "assets/images/brand", existbrand.Image);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                existbrand.Image = newFileName;
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Brand existbrand = _context.Brands.FirstOrDefault(x => x.Id == id);
            if (existbrand == null)
            {
                return Json(new { status = 404 });
            }
            if (!string.IsNullOrWhiteSpace(existbrand.Image))
            {
                FileManager.Delete(_env.WebRootPath, "assets/images//brand", existbrand.Image);
            }


            _context.Brands.Remove(existbrand);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
