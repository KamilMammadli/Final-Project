using Microsoft.AspNetCore.Authorization;
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
        public IActionResult Index(string search,int page = 1)
        {
            var query = _context.Blogs.AsQueryable();
           
            if (search!=null)
            {
                query = query.Where(x => x.Name.ToUpper().Contains(search.ToUpper()));
            }
            ViewBag.Tags = _context.BTags.ToList();
            var totalPage = query.Count() / 4d;
            ViewBag.TotalPage = Math.Ceiling(totalPage);
            ViewBag.SelectedPage = page;
            List<Blog> blogs = query.Include(x => x.BlogBTags).Skip((page - 1) * 4).Take(4).ToList();
            return View(blogs);
        }

        public IActionResult Detail(int id)
        {
            Blog blog = _context.Blogs.Include(x => x.BlogBTags).ThenInclude(x => x.BTag).FirstOrDefault(x => x.Id == id);

            if (blog == null) return RedirectToAction("error", "home");
            
            ViewBag.Blogs = _context.Blogs.ToList();
            ViewBag.Tags = _context.BTags.ToList();
            return View(blog);



        }

    
    }
}
