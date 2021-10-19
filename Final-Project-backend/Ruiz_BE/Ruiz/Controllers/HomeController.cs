﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ruiz.DAL;
using Ruiz.Models;
using Ruiz.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Setting = _context.Settings.FirstOrDefault(),
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Blogs = _context.Blogs.ToList(),
            };
            return View(homeVM);
        }

        
    }
}
