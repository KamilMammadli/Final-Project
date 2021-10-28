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
    public class TagController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TagController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Tags.Count() / 4d);

            List<Tag> tags = _context.Tags
                 .Skip((page - 1) * 4).Take(4)
                .ToList();

            return View(tags);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tag tags)
        {
            if (!ModelState.IsValid) return View();


            _context.Tags.Add(tags);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Tag tag = _context.Tags.FirstOrDefault(x => x.Id == id);

            if (tag == null) return RedirectToAction("error", "home");

            return View(tag);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Tag tag)
        {
            if (!ModelState.IsValid) return View();

            Tag existtag = _context.Tags.FirstOrDefault(x => x.Id == tag.Id);

            if (existtag == null) return RedirectToAction("error", "home");

            existtag.Name = tag.Name;


            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Tag existtag = _context.Tags.FirstOrDefault(x => x.Id == id);
            if (existtag == null)
            {
                return Json(new { status = 404 });
            }


            _context.Tags.Remove(existtag);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
