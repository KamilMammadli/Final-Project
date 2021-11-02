using Ruiz.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.ViewModels
{
    public class OrderCreateViewModel
    {
      
        [Required]
        [StringLength(maximumLength: 250)]
        public string Address { get; set; }
        [StringLength(maximumLength: 250)]
        public string Note { get; set; }

        public List<BasketItem> BasketItems { get; set; }
    }
}
