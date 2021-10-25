using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogViewModel blogVM = new BlogViewModel
            {
                Blogs = _context.Blogs.ToList(),
            };
            ViewBag.Tags = _context.Tags.ToList();
            return View(blogVM);
        }

        public IActionResult Detail(int id)
        {
            Blog blog = _context.Blogs.Include(x => x.BlogTags).ThenInclude(x => x.Tag).FirstOrDefault(x => x.Id == id);

            if (blog == null) return RedirectToAction("error", "home");
            ViewBag.Blogs = _context.Blogs.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View(blog);



        }

    }
}
