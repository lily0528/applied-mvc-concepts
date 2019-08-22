using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models.ViewModels
{
    public class CreateMovieViewModel
    {
        [Required(ErrorMessage = "My field Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "My field Name is required")]
       //[DisplayName("dddd")]
       //need to use using System.ComponentModel;
        public string Name { get; set; }

        [Required]
        public int? Rating { get; set; }

        public DateTime CreateDate { get; set; }

        public menu Category { get; set; }
        public CreateMovieViewModel()
        {
            CreateDate = DateTime.Now;

        }

    }
  
    public enum menu
        {
              Drama,
              Comedy,
              Horror,
              Romance,
              SciFi,
              Adventure
        }
}