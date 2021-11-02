using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class AppUser:IdentityUser
    {
        [StringLength(maximumLength:50)]
        public string FullName { get; set; }
        [StringLength(maximumLength: 100)]
        public string Address1 { get; set; }
        [StringLength(maximumLength: 100)]
        public string Address2 { get; set; }
        public bool IsAdmin { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
