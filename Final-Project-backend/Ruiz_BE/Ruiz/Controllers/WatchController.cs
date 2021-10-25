using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruiz.DAL;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{
    public class WatchController : Controller
    {
        private readonly AppDbContext _context;
        public WatchController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? categoryId, double? minPrice, double? maxPrice, string sort, int page = 1)
        {
            var query = _context.Watches.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(x => x.CategoryId == categoryId);
            }

            ViewBag.Categories = _context.Categories.Include(x => x.Watches).ToList();
            ViewBag.MinPrice = query.OrderBy(x => x.DiscountedPrice).First().DiscountedPrice;
            ViewBag.MaxPrice = query.OrderByDescending(x => x.DiscountedPrice).First().DiscountedPrice;
            ViewBag.SelectedMinPrice = minPrice ?? ViewBag.MinPrice;
            ViewBag.SelectedMaxPrice = maxPrice ?? ViewBag.MaxPrice;
            ViewBag.Sort = sort;
            ViewBag.Tags = _context.Tags.ToList();

            if (minPrice != null && maxPrice != null)
            {
                query = query.Where(x => x.DiscountedPrice >= minPrice && x.DiscountedPrice <= maxPrice);
            }

            if (!string.IsNullOrWhiteSpace(sort))
            {
                switch (sort)
                {
                    case "A-Z":
                        query = query.OrderBy(x => x.Name);
                        break;
                    case "Z-A":
                        query = query.OrderByDescending(x => x.Name);
                        break;
                    case "Low-High":
                        query = query.OrderBy(x => x.DiscountedPrice);
                        break;
                    case "High-Low":
                        query = query.OrderByDescending(x => x.DiscountedPrice);
                        break;
                    default:
                        break;
                }
               
            }
            var totalPage = query.Count() / 9d;
            ViewBag.TotalPage = Math.Ceiling(totalPage);
            ViewBag.CategoryId = categoryId;



            ViewBag.SelectedPage = page;
            List<Watch> watches = query.Include(x => x.Brand).Include(x => x.WatchImages).Skip((page - 1) * 9).Take(9).ToList();
            return View(watches);
        }

        public IActionResult Detail(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();


            Watch watch = _context.Watches
                .Include(x => x.Brand)
                .Include(x => x.Category)
                .Include(x => x.WatchImages)
                .Include(x => x.WatchTags).ThenInclude(x => x.Tag)
                .FirstOrDefault(x => x.Id == id);


            if (watch == null) return NotFound();

            

            List<Watch> relatedWatches = _context.Watches
                .Include(x => x.Brand)
                .Include(x => x.WatchImages)
                .Where(x => x.CategoryId == watch.CategoryId && x.Id != watch.Id).ToList();

            ViewBag.RelatedWatches = relatedWatches;

            return View(watch);
        }
    }
}
