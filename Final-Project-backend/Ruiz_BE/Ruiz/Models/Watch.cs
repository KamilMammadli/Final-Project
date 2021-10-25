using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Watch
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double CostPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double DiscountedPrice { get; set; }
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public int Rate { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string Code { get; set; }
        [StringLength(maximumLength: 50)]
        public string Color { get; set; }
        [StringLength(maximumLength: 1500)]
        public string Desc { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsNew { get; set; }
        public bool IsFeatured { get; set; }
        [NotMapped]
        public IFormFile PosterImage { get; set; }
        [NotMapped]
        public List<IFormFile> Images { get; set; }
        [NotMapped] 
        public List<int> ImageIds { get; set; }
        public Brand Brand { get; set; }
        public List<WatchImage> WatchImages { get; set; }
        [NotMapped]
        public List<int> TagIds { get; set; } 
        public List<WatchTag> WatchTags { get; set; }
        public Category Category { get; set; }
    }
}
