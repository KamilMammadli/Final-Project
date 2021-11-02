using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        
        
        }

        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BTag> BTags { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<BlogBTag> BlogBTags { get; set; }
        public DbSet<Watch> Watches { get; set; }
        public DbSet<WatchImage> WatchImages { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<WatchTag> WatchTags { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }




    }

}
