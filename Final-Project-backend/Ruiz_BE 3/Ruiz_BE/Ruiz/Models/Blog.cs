using Microsoft.AspNetCore.Http;
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
        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        [StringLength(maximumLength: 100)]
        public string Name { get; set; }
        [StringLength(maximumLength: 1000)]
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        [StringLength(maximumLength: 70)]
        public string AuthorName { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public List<int> BlogBTagBTagIds { get; set; }
        public List<BlogBTag> BlogBTags { get; set; }

    }
}
