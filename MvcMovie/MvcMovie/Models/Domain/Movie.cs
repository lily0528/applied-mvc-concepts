using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public string Name { get; set; }
        public int? Rating { get; set; }
        public string Category { get; set; }
        public DateTime CreateDate { get; set; }
        
        public Movie()
        {
            CreateDate = DateTime.Now;
           
        }

    }
}