using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class WatchImage
    {

        public int Id { get; set; }
        public int WatchId { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }
        public bool? PosterStatus { get; set; }
        public Watch Watch { get; set; }



    }
}
