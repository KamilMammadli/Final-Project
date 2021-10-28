using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.ViewModels
{
    public class HomeViewModel
    {
        public Setting Setting { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Watch> Watches { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
