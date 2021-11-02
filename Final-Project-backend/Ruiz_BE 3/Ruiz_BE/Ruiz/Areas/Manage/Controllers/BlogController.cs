using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Blogs.Count() / 4d);

            List<Blog> blogs = _context.Blogs
                .Include(x => x.BlogBTags).Skip((page - 1) * 4).Take(4).ToList();

            return View(blogs);
        }


        public IActionResult Create()
        {
            ViewBag.BTags = _context.BTags.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog)
        {
            ViewBag.BTags = _context.BTags.ToList();
            

                if (blog.ImageFile != null)
                {
                    if (blog.ImageFile.ContentType != "image/jpeg" && blog.ImageFile.ContentType != "image/png")
                    {
                        ModelState.AddModelError("ImageFile", "Fayl   .jpg ve ya   .png sonlugu ile bite biler!");
                        return View();
                    }
                    if (blog.ImageFile.Length > 2097152)
                    {
                        ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk ola bilmez!");
                        return View();
                    }


                    blog.Image = FileManager.Save(_env.WebRootPath, "assets/images/blog", blog.ImageFile);

                }



               
            blog.BlogBTags = new List<BlogBTag>();

            if (blog.BlogBTagBTagIds != null)
            {
                foreach (var btagId in blog.BlogBTagBTagIds)
                {
                    BlogBTag blogTag = new BlogBTag
                    {
                        BlogId = blog.Id,
                        BTagId=btagId
                    };
                    blog.BlogBTags.Add(blogTag);
                }
            }
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {

            Blog blog = _context.Blogs.Include(x => x.BlogBTags).FirstOrDefault(x => x.Id == id);
            blog.BlogBTagBTagIds = blog.BlogBTags.Select(x => x.BTagId).ToList();

            if (blog == null) RedirectToAction("error", "home");

            ViewBag.BTags = _context.BTags.ToList();


            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.BTags = _context.BTags.ToList();
                return View();
            }

            Blog existblog = _context.Blogs.Include(x => x.BlogBTags).FirstOrDefault(x => x.Id == blog.Id);

            if (existblog == null) return NotFound();

            existblog.Name = blog.Name;
            existblog.AuthorName = blog.AuthorName;
            existblog.Content = blog.Content;
            existblog.CreatedAt = blog.CreatedAt;

            if (blog.ImageFile != null)
            {
                if (blog.ImageFile.ContentType != "image/jpeg" && blog.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Faylin sonlugu  .jpg ve ya   .png  ile bitmelidir!");
                    return View(blog);
                }

                if (blog.ImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("ImageFile", "Fayl olcusu 2mb-dan boyuk olmamalidir!");
                    return View(blog);
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "assets/images/blog", blog.ImageFile);

                if (!string.IsNullOrWhiteSpace(existblog.Image))
                {
                    string oldPath = Path.Combine(_env.WebRootPath, "assets/images/blog", existblog.Image);
                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

                existblog.Image = newFileName;
            }

           
            existblog.BlogBTags.RemoveAll(x => !blog.BlogBTagBTagIds.Contains(x.BTagId));
            if (blog.BlogBTagBTagIds != null)
            {
                foreach (var btagId in blog.BlogBTagBTagIds)
                {
                    BlogBTag blogTag = existblog.BlogBTags.FirstOrDefault(x => x.BTagId == btagId);

                    if (blogTag == null)
                    {
                        blogTag = new BlogBTag
                        {
                            BlogId = blog.Id,
                            BTagId = btagId
                        };
                        existblog.BlogBTags.Add(blogTag);
                    }
                }
            }

           

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Blog existblog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            if (existblog == null)
            {
                return Json(new { status = 404 });
            }

            if (!string.IsNullOrWhiteSpace(existblog.Image))
            {
                FileManager.Delete(_env.WebRootPath, "assets/images/blog", existblog.Image);
            }

            
            _context.Blogs.Remove(existblog);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
