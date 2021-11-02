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
    public class BTagController : Controller
    {

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BTagController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.BTags.Count() / 4d);

            List<BTag> btags = _context.BTags
                 .Skip((page - 1) * 4).Take(4)
                .ToList();

            return View(btags);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BTag btags)
        {
            if (!ModelState.IsValid) return View();


            _context.BTags.Add(btags);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            BTag btag = _context.BTags.FirstOrDefault(x => x.Id == id);

            if (btag == null) return RedirectToAction("error", "home");

            return View(btag);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BTag btag)
        {
            if (!ModelState.IsValid) return View();

            BTag existbtag = _context.BTags.FirstOrDefault(x => x.Id == btag.Id);

            if (existbtag == null) return RedirectToAction("error", "home");

            existbtag.Name = btag.Name;


            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            BTag existbtag = _context.BTags.FirstOrDefault(x => x.Id == id);
            if (existbtag == null)
            {
                return Json(new { status = 404 });
            }


            _context.BTags.Remove(existbtag);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
