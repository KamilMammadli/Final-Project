using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string SmallImage { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string DetailImage { get; set; }
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Content { get; set; }
        [StringLength(maximumLength: 70)]
        public DateTime CreatedAt { get; set; }
        [StringLength(maximumLength: 70)]
        public string AuthorName { get; set; }
        [NotMapped]
        public List<int> TagIds { get; set; }
        public List<BlogTag> BlogTags { get; set; }

    }
}
