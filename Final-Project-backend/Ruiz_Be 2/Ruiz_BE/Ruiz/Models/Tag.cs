using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [StringLength(maximumLength: (50))]
        public string Name { get; set; }
        public List<BlogTag> BlogTags { get; set; }
        public List<WatchTag> WatchTags { get; set; }
    }
}
