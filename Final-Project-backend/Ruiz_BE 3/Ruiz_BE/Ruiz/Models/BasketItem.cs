﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ruiz.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public int WatchId { get; set; }
        public int Count { get; set; }

        public AppUser AppUser { get; set; }
        public Watch Watch { get; set; }
    }
}