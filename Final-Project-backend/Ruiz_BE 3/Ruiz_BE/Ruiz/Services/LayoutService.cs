using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;
        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public Setting GetSetting()
        {
            return _context.Settings.FirstOrDefault();
        }

        public BasketViewModel GetBasket()
        {
            var basket = _httpContextAccessor.HttpContext.Request.Cookies["Basket"];

            BasketViewModel basketData = new BasketViewModel
            {
                BasketItems = new List<BasketItemViewModel>(),
                TotalPrice = 0
            };

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated && _userManager.Users.Any(x => x.UserName == _httpContextAccessor.HttpContext.User.Identity.Name && x.IsAdmin == false))
            {
                var basketItems = _context.BasketItems.Include(x => x.AppUser).Include(x => x.Watch).ThenInclude(x => x.WatchImages).Where(x => x.AppUser.UserName == _httpContextAccessor.HttpContext.User.Identity.Name);

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
            }
            else
            {
                if (basket != null)
                {
                    List<BasketCookieItemViewModel> cookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemViewModel>>(basket);

                    foreach (var item in cookieItems)
                    {
                        Watch watch = _context.Watches.Include(x => x.WatchImages).FirstOrDefault(x => x.Id == item.Id);

                        if (watch != null)
                        {
                            BasketItemViewModel basketItemVM = new BasketItemViewModel
                            {
                                Watch = watch,
                                Count = item.Count
                            };

                            basketData.TotalPrice += basketItemVM.Watch.DiscountedPrice * item.Count;
                            basketData.BasketItems.Add(basketItemVM);
                            basketData.Count++;
                        }

                    }
                }

            }


            return basketData;
        }

    }
}
