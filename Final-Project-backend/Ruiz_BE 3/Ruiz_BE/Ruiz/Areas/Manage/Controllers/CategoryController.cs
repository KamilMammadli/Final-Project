using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Ruiz.DAL;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Areas.Manage.Controllers
{

    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin,Editor")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CategoryController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Categories.Count() / 4d);

            List<Category> categories = _context.Categories
                 .Skip((page - 1) * 4).Take(4)
                .ToList();

            return View(categories);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category categories)
        {
            if (!ModelState.IsValid) return View();

            _context.Categories.Add(categories);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(x => x.Id == id);

            if (category == null) return RedirectToAction("error", "home");

            return View(category);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (!ModelState.IsValid) return View();

            Category existcatg = _context.Categories.FirstOrDefault(x => x.Id == category.Id);

            if (existcatg == null) return RedirectToAction("error", "home");

            existcatg.Name = category.Name;


            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Category existcatg = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (existcatg == null)
            {
                return Json(new { status = 404 });
            }


            _context.Categories.Remove(existcatg);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}

   