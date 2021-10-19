using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string BgImage { get; set; }
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [StringLength(maximumLength: 50)]
        public string SubTitle { get; set; }
        [StringLength(maximumLength: 150)]
        public string Content { get; set; }
        [StringLength(maximumLength: 50)]
        public string SubTitle2 { get; set; }
        [Required]
        public int Order { get; set; }
        [StringLength(maximumLength: 50)]
        public string RedirectUrl { get; set; }
        [StringLength(maximumLength: 50)]
        public string BtnText { get; set; }
    }
}
