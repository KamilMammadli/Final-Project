using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [StringLength(maximumLength: (50))]
        public string Name { get; set; }
        [StringLength(maximumLength: (50))]
        public string Image { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public List<Watch> Watches { get; set; }
    }
}
