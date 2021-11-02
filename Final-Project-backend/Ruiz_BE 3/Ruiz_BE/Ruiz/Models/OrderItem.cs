using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int WatchId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public Watch Watch { get; set; }
        public Order Order { get; set; }
    }
}
