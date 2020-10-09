﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogApp.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; } 
        public DateTime UploadDate { get; set; }
        public bool Confirmation { get; set; }
        public bool Home { get; set; }
        public int CategoryId { get;set;}
    }
}