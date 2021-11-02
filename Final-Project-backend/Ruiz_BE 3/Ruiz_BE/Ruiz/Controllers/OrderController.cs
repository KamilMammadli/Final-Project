using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.Services;
using Ruiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;

        public OrderController(UserManager<AppUser> userManager, AppDbContext context, IEmailService emailService)
        {
            _userManager = userManager;
            _context = context;
            _emailService = emailService;
        }
        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var orders = _context.Orders.Include(x => x.OrderItems).Where(x => x.AppUserId == user.Id).ToList();
            return View(orders);
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Detail(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            Order order = await _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Watch).FirstOrDefaultAsync(x => x.AppUserId == user.Id && x.Id == id);

            if (order == null) return NotFound();

            return View(order);
        }

        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Checkout()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            OrderCreateViewModel orderCreateVM = new OrderCreateViewModel
            {
                Address = user.Address1,
              
                BasketItems = _context.BasketItems.Include(x => x.Watch).Where(x => x.AppUserId == user.Id).ToList()
            };

            return View(orderCreateVM);
        }

        [Authorize(Roles = "Member")]
        [HttpPost]
        public async Task<IActionResult> Checkout(OrderCreateViewModel orderVM)
        {
            if (!ModelState.IsValid) return RedirectToAction("checkout");

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            List<BasketItem> basketItems = await _context.BasketItems.Include(x => x.Watch).Where(x => x.AppUserId == user.Id).ToListAsync();

            if (basketItems.Count() == 0)
            {
                TempData["Error"] = "Səbət boşdur!";
                return RedirectToAction("checkout");
            }


            Order order = new Order
            {
                Address = orderVM.Address,
                Note = orderVM.Note,
                AppUserId = user.Id,
                CreatedAt = DateTime.UtcNow,
                OrderItems = new List<OrderItem>()
            };

            foreach (var basketItem in basketItems)
            {
                OrderItem orderItem = new OrderItem
                {
                   WatchId = basketItem.WatchId,
                    Price = basketItem.Watch.DiscountedPrice,
                    Count = basketItem.Count,
                    Name = basketItem.Watch.Name
                };

                order.OrderItems.Add(orderItem);
                order.TotalPrice += orderItem.Price * orderItem.Count;
            }

            await _context.Orders.AddAsync(order);

            _context.BasketItems.RemoveRange(basketItems);
            await _context.SaveChangesAsync();

            TempData["Succeed"] = "Sifariş uğurla yaradıldı!";

            return RedirectToAction("index", "home");
        }
    }
}