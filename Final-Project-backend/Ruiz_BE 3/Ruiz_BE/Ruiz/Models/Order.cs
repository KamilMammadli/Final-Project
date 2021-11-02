using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class Order
    {

        public int Id { get; set; }
        public string AppUserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Address { get; set; }
        [StringLength(maximumLength: 250)]
        public string Note { get; set; }
        [StringLength(maximumLength: 250)]
        public string AdminNote { get; set; }
        public double TotalPrice { get; set; }
        public bool? Status { get; set; }
        public AppUser AppUser { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
