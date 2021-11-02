using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruiz.DAL;
using Ruiz.Helpers;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class WatchController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public WatchController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.SelectedPage = page;
            ViewBag.TotalPage = Math.Ceiling(_context.Watches.Count() / 4d);

            List<Watch> watches = _context.Watches
                .Include(x => x.Category)
                .Include(x => x.Brand)
                .Skip((page - 1) * 4).Take(4).ToList();

            return View(watches);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Watch watch)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();


            if (!ModelState.IsValid) return View();


            if (!_context.Categories.Any(x => x.Id == watch.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Category not available!");
                return View();
            }

            if (!_context.Brands.Any(x => x.Id == watch.BrandId))
            {
                ModelState.AddModelError("BrandId", "Brand not available!");
                return View();
            }

            if (_context.Watches.Any(x => x.Code == watch.Code))
            {
                ModelState.AddModelError("Code", "The code cannot be repeated!");
                return View();
            }

            if (watch.PosterImage == null)
            {
                ModelState.AddModelError("PosterImage", "It is important!");
                return View();
            }


            if (watch.PosterImage.ContentType != "image/jpeg" && watch.PosterImage.ContentType != "image/png")
            {
                ModelState.AddModelError("PosterImage", "The file can be .jpg or .png!");
                return View();
            }

            if (watch.PosterImage.Length > 2097152)
            {
                ModelState.AddModelError("PosterImage", "The file size cannot be larger than 2 mb!");
                return View();
            }

            if (watch.Images != null)
            {
                foreach (var item in watch.Images)
                {
                    if (item.ContentType != "image/jpeg" && item.ContentType != "image/png")
                    {
                        ModelState.AddModelError("Images", "The file can be .jpg or .png!");
                        return View();
                    }

                    if (item.Length > 2097152)
                    {
                        ModelState.AddModelError("Images", "The file size cannot be larger than 2 mb!");
                        return View();
                    }

                }
            }

            watch.WatchImages = new List<WatchImage>();
            watch.WatchTags = new List<WatchTag>();

            WatchImage posterImage = new WatchImage
            {
                PosterStatus = true,
                Image = FileManager.Save(_env.WebRootPath, "assets/images/product", watch.PosterImage)
            };
            watch.WatchImages.Add(posterImage);



            if (watch.Images != null)
            {
                foreach (var item in watch.Images)
                {
                    WatchImage watchImage = new WatchImage
                    {
                        PosterStatus = null,
                        Image = FileManager.Save(_env.WebRootPath, "assets/images/product", item)
                    };
                    watch.WatchImages.Add(watchImage);
                }
            }


            if (watch.TagIds != null)
            {
                foreach (var tagId in watch.TagIds)
                {
                    WatchTag watchTag = new WatchTag
                    {
                        TagId = tagId
                    };
                    watch.WatchTags.Add(watchTag);
                }
            }

            _context.Watches.Add(watch);
            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Watch watch = _context.Watches.Include(x => x.WatchImages).Include(x => x.WatchTags).FirstOrDefault(x => x.Id == id);
            watch.TagIds = watch.WatchTags.Select(x => x.TagId).ToList();
            if (watch == null) return NotFound();

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.Tags.ToList();



            return View(watch);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Watch watch)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Watch existWtch = _context.Watches.Include(x => x.WatchImages).Include(x => x.WatchTags).FirstOrDefault(x => x.Id == watch.Id);

            if (existWtch == null) return NotFound();

            if (!_context.Categories.Any(x => x.Id == watch.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Category is not available!");
                return View();
            }

            if (!_context.Brands.Any(x => x.Id == watch.BrandId))
            {
                ModelState.AddModelError("BrandId", "Brand is not available!");
                return View();
            }

            if (watch.PosterImage != null)
            {
                if (watch.PosterImage.ContentType != "image/jpeg" && watch.PosterImage.ContentType != "image/png")
                {
                    ModelState.AddModelError("PosterImage", "The file can be .jpg or .png!");
                    return View();
                }

                if (watch.PosterImage.Length > 2097152)
                {
                    ModelState.AddModelError("PosterImage", "The file size cannot be larger than 2 mb!");
                    return View();
                }
            }


            if (watch.Images != null)
            {
                foreach (var item in watch.Images)
                {
                    if (item.ContentType != "image/jpeg" && item.ContentType != "image/png")
                    {
                        ModelState.AddModelError("Images", "The file can be .jpg or .png!");
                        return View();
                    }

                    if (item.Length > 2097152)
                    {
                        ModelState.AddModelError("Images", "The file size cannot be larger than 2 mb!");
                        return View();
                    }

                }
            }

            existWtch.Name = watch.Name;
            existWtch.Price = watch.Price;
            existWtch.DiscountedPrice = watch.DiscountedPrice;
            existWtch.Code = watch.Code;
            existWtch.CostPrice = watch.CostPrice;
            existWtch.Desc = watch.Desc;
            existWtch.CategoryId = watch.CategoryId;
            existWtch.Color = watch.Color;
            existWtch.IsAvailable = watch.IsAvailable;
            existWtch.IsNew = watch.IsNew;
            existWtch.IsFeatured = watch.IsFeatured;
            existWtch.BrandId = watch.BrandId;


            if (watch.PosterImage != null)
            {
                string filename = FileManager.Save(_env.WebRootPath, "assets/images/product", watch.PosterImage);

                WatchImage oldposterimg = existWtch.WatchImages.FirstOrDefault(x => x.PosterStatus == true);

                if (oldposterimg != null)
                {
                    FileManager.Delete(_env.WebRootPath, "assets/images/product", oldposterimg.Image);
                    oldposterimg.Image = filename;
                }
                else
                {
                    oldposterimg = new WatchImage
                    {
                        Image = filename,
                        PosterStatus = true
                    };
                    existWtch.WatchImages.Add(oldposterimg);
                }

            }



            existWtch.WatchImages.RemoveAll(x => x.PosterStatus == null && !watch.ImageIds.Contains(x.Id));

            if (watch.Images != null)
            {
                foreach (var item in watch.Images)
                {
                    WatchImage watchImage = new WatchImage
                    {
                        PosterStatus = null,
                        Image = FileManager.Save(_env.WebRootPath, "assets/images/product", item)
                    };
                    existWtch.WatchImages.Add(watchImage);
                }
            }

            existWtch.WatchTags.RemoveAll(x => !watch.TagIds.Contains(x.TagId));
            if (watch.TagIds != null)
            {
                foreach (var tagId in watch.TagIds)
                {
                    WatchTag watchTag = existWtch.WatchTags.FirstOrDefault(x => x.TagId == tagId);

                    if (watchTag == null)
                    {
                        watchTag = new WatchTag
                        {
                            WatchId = watch.Id,
                            TagId = tagId
                        };
                        existWtch.WatchTags.Add(watchTag);
                    }
                }
            }


            _context.SaveChanges();

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            Watch existWatch = _context.Watches.Include(x => x.WatchImages).FirstOrDefault(x => x.Id == id);
            if (existWatch == null)
            {
                return Json(new { status = 400 });
            }
            foreach (var item in existWatch.WatchImages)
            {
                FileManager.Delete(_env.WebRootPath, "assets/images/product", item.Image);
            }

            var removeImages = _context.WatchImages.Where(x => x.WatchId == existWatch.Id).ToList();
            foreach (var item in removeImages)
            {
                _context.WatchImages.Remove(item);
            }

            if (existWatch.WatchTags != null)
            {
                var removeTags = _context.WatchTags.Where(x => x.WatchId == existWatch.Id).ToList();
                foreach (var item in removeTags)
                {
                    _context.WatchTags.Remove(item);
                }
            }

            _context.Watches.Remove(existWatch);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
