using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 50)]
        public string SubTitle { get; set; }
        [StringLength(maximumLength: 150)]
        public string Content { get; set; }
        [StringLength(maximumLength: 50)]
        public string SubTitle2 { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required]
        public int Order { get; set; }
        [StringLength(maximumLength: 50)]
        public string RedirectUrl { get; set; }
        [StringLength(maximumLength: 50)]
        public string BtnText { get; set; }
    }
}
