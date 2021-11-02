using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{

    public class WatchController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WatchController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int? categoryId, string search ,double? minPrice, double? maxPrice, string sort, int page = 1)
        {
            var query = _context.Watches.AsQueryable();

            if (categoryId != null)
            {
                query = query.Where(x => x.CategoryId == categoryId);
            }

            if (search != null)
            {
                query = query.Where(x => x.Name.ToUpper().Contains(search.ToUpper())|| x.Color.ToUpper().Contains(search.ToUpper()) || x.WatchTags.Any(x=>x.Tag.Name.ToUpper().Contains(search.ToUpper())) ||x.Category.Name.ToUpper().Contains(search.ToUpper()) || x.Brand.Name.ToUpper().Contains(search.ToUpper()));
            }
            if (query.Count()!=0)
            {

                ViewBag.MinPrice = query.OrderBy(x => x.DiscountedPrice).First().DiscountedPrice;
                ViewBag.MaxPrice = query.OrderByDescending(x => x.DiscountedPrice).First().DiscountedPrice;
            }
            ViewBag.Categories = _context.Categories.Include(x => x.Watches).ToList();
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
            List<Watch> watches= _context.Watches.Include(x => x.WatchImages).ToList();
            ViewBag.RelatedWatches = relatedWatches;
            ViewBag.Watches = watches;

            return View(watch);
        }


        public IActionResult AddToBasket(int id)
        {
            Watch watch = _context.Watches.Include(x => x.BasketItems).FirstOrDefault(x => x.Id == id);

            if (watch == null) return NotFound();

            if (User.Identity.IsAuthenticated && _userManager.Users.Any(x => x.UserName == User.Identity.Name && x.IsAdmin == false))
            {
                AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

                BasketItem basketItem = watch.BasketItems.FirstOrDefault(x => x.AppUserId == user.Id);
                if (basketItem != null)
                {
                    basketItem.Count++;
                }
                else
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        Count = 1,
                        WatchId = id
                    };

                    watch.BasketItems.Add(basketItem);
                }

                _context.SaveChanges();
            }
            else
            {
                var basket = HttpContext.Request.Cookies["Basket"];
                List<BasketCookieItemViewModel> basketItems;
                if (basket == null)
                {
                    basketItems = new List<BasketCookieItemViewModel>();
                    basketItems.Add(new BasketCookieItemViewModel
                    {
                        Id = watch.Id,
                        Count = 1
                    });

                    var basketStr = JsonConvert.SerializeObject(basketItems);
                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                }
                else
                {
                    basketItems = JsonConvert.DeserializeObject<List<BasketCookieItemViewModel>>(basket);

                    BasketCookieItemViewModel basketItem = basketItems.FirstOrDefault(x => x.Id == watch.Id);

                    if (basketItem == null)
                    {
                        basketItem = new BasketCookieItemViewModel
                        {
                            Id = watch.Id,
                            Count = 1
                        };
                        basketItems.Add(basketItem);
                    }
                    else
                    {
                        basketItem.Count++;
                    }

                    var basketStr = JsonConvert.SerializeObject(basketItems);
                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                }
                BasketViewModel basketData = new BasketViewModel
                {
                    BasketItems = new List<BasketItemViewModel>(),
                    TotalPrice = 0
                };
                foreach (var item in basketItems)
                {
                    Watch existWatch = _context.Watches.Include(x => x.WatchImages).FirstOrDefault(x => x.Id == item.Id);

                    if (existWatch != null)
                    {
                        BasketItemViewModel basketItemVM = new BasketItemViewModel
                        {
                            Watch = existWatch,
                            Count = item.Count
                        };

                        basketData.TotalPrice += basketItemVM.Watch.DiscountedPrice * item.Count;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                    }

                }
            }
            return RedirectToAction("index");
        }

        public IActionResult DeleteBasketItem(int id)
        {
            Watch watch = _context.Watches.Include(x => x.BasketItems).FirstOrDefault(x => x.Id == id);
            if (watch == null) return NotFound();

            BasketViewModel basketData = new BasketViewModel
            {
                BasketItems = new List<BasketItemViewModel>(),
                TotalPrice = 0
            };
            if (User.Identity.IsAuthenticated && _userManager.Users.Any(x => x.UserName == User.Identity.Name && x.IsAdmin == false))
            {
                AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;
                BasketItem basketItem = watch.BasketItems.FirstOrDefault(x => x.AppUserId == user.Id);
                if (basketItem != null)
                {
                    if (basketItem.Count > 1)
                    {
                        basketItem.Count--;
                    }
                    else
                    {
                        _context.BasketItems.Remove(basketItem);
                    }
                }
                _context.SaveChanges();
                var basketItems = _context.BasketItems.Include(x => x.AppUser).Include(x => x.Watch).Where(x => x.AppUser.UserName == User.Identity.Name);
                foreach (var item in basketItems)
                {
                    BasketItemViewModel basketItemVM = new BasketItemViewModel
                    {
                        Watch = item.Watch,
                        Count = item.Count
                    };
                    basketData.TotalPrice += basketItemVM.Watch.DiscountedPrice * item.Count;
                    basketData.BasketItems.Add(basketItemVM);
                    basketData.Count++;
                }
                return RedirectToAction("index");

            }
            else
            {
                var basket = HttpContext.Request.Cookies["Basket"];
                List<BasketCookieItemViewModel> basketItems = JsonConvert.DeserializeObject<List<BasketCookieItemViewModel>>(basket);
                var basketItem = basketItems.Find(x => x.Id == id);

                if (basketItem != null)
                {
                    if (basketItem.Count > 1)
                    {
                        basketItem.Count--;
                    }
                    else
                    {
                        basketItems.Remove(basketItem);
                    }
                }

                var basketStr = JsonConvert.SerializeObject(basketItems);
                HttpContext.Response.Cookies.Append("Basket", basketStr);

                foreach (var item in basketItems)
                {
                    Watch existWatch = _context.Watches.Include(x => x.WatchImages).FirstOrDefault(x => x.Id == item.Id);

                    if (existWatch != null)
                    {
                        BasketItemViewModel basketItemVM = new BasketItemViewModel
                        {
                            Watch = existWatch,
                            Count = item.Count
                        };

                        basketData.TotalPrice += basketItemVM.Watch.DiscountedPrice * item.Count;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                    }
                }
            }


            return RedirectToAction("index");
        }
    }
}
