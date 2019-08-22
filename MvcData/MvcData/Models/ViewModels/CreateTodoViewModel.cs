using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcData.Models.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required (ErrorMessage = "My Description is required!")]
        public string Description { get; set; }
        [Required]
        public string Title{ get; set; }
        public DateTime DueDate { get; set; }
    }
}