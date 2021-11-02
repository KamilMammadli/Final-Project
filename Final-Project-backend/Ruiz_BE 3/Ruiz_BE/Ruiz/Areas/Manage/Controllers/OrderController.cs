using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Areas.Manage.Controllers
{
    [Authorize(Roles = "SuperAdmin,Admin")]
    [Area("manage")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IEmailService _emailService;

        public OrderController(AppDbContext context, IEmailService emailService)
        {
            _context = context;
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            var orders = _context.Orders.Include(x => x.OrderItems).Include(x => x.AppUser).ToList();

            return View(orders);
        }

        public IActionResult Detail(int id)
        {
            Order order = _context.Orders.Include(x => x.OrderItems).ThenInclude(x => x.Watch).Include(x => x.AppUser).FirstOrDefault(x => x.Id == id);

            if (order == null) return NotFound();


            return View(order);
        }

        public IActionResult Accept(int id, string note)
        {
            Order order = _context.Orders.Include(x => x.OrderItems).Include(x => x.AppUser).FirstOrDefault(x => x.Id == id);

            if (order == null) return Json(new { status = 404 });

            order.Status = true;
            order.AdminNote = note;

            _context.SaveChanges();

            string body = string.Empty;
            using (StreamReader reader = new StreamReader("wwwroot/templates/order.html"))
            {
                body = reader.ReadToEnd();
            }



            string orderItemsHtml = string.Empty;
            foreach (var item in order.OrderItems)
            {
                string tr = @$"<tr>
                                    <td width=\""75%\"" align=\""left\"" style =\""font - family: Open Sans, Helvetica, Arial, sans-serif; font - size: 16px; font - weight: 400; line - height: 24px; padding: 15px 10px 5px 10px; \"" > {item.Name} </td>
                                 <td width=\""25 % \"" align =\""left\"" style=\""font - family: Open Sans, Helvetica, Arial, sans-serif; font - size: 16px; font - weight: 400; line - height: 24px; padding: 15px 10px 5px 10px; \"" > {item.Count}X{item.Price} $ </td>
                                       </tr>";

                orderItemsHtml += tr;
            }
            body = body.Replace("{{total}}", order.TotalPrice.ToString()).Replace("{{orderItems}}", orderItemsHtml);

            _emailService.Send(order.AppUser.Email, "Order accepted!", body);

            return Json(new { status = 200 });
        }

        public IActionResult Reject(int id, string note)
        {
            Order order = _context.Orders.FirstOrDefault(x => x.Id == id);

            if (order == null) return Json(new { status = 404 });

            if (string.IsNullOrWhiteSpace(note))
            {
                return Json(new { status = 400 });
            }

            order.Status = false;
            order.AdminNote = note;

            _context.SaveChanges();

            return Json(new { status = 200 });
        }

    }
}