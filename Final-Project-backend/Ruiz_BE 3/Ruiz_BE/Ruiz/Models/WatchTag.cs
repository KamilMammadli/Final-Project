using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class WatchTag
    {
        public int Id { get; set; }
        public int WatchId { get; set; }
        public int TagId { get; set; }
        public Watch Watch { get; set; }
        public Tag Tag { get; set; }
    }
}
