﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.ViewModels
{
    public class IndexMovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public string Category { get; set; }
        public DateTime CreateDate { get; set; }
    }
}