using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Testimonial
    {    
        public int Id { get; set; }
        [StringLength(maximumLength: (100))]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [StringLength(maximumLength: (50))]
        public string FullName { get; set; }
        [StringLength(maximumLength: (50))]
        public string Position { get; set; }
        [StringLength(maximumLength: (300))]
        public string Text { get; set; }

    }
}
