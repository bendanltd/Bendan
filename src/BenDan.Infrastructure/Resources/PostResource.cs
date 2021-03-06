﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BenDan.Infrastructure.Resources
{
    public class PostResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime UpDateTime { get; set; }
        public string Remark { get; set; }
    }
}
