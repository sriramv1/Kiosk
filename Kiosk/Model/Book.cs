﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Model
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string PublishedYear { get; set; }
        public string ISBN { get; set; }
        public string Thumbnail { get; set; }

        public int? PageCount { get; set; }
    }
}
