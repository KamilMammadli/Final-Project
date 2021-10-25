using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Testimonial
    {    
        public int Id { get; set; }
        [StringLength(maximumLength: (50))]
        public string Image { get; set; }
        [StringLength(maximumLength: (50))]
        public string FullName { get; set; }
        [StringLength(maximumLength: (50))]
        public string Position { get; set; }
        [StringLength(maximumLength: (300))]
        public string Text { get; set; }

    }
}
