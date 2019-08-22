using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcData.Models.Domain
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateCreated { get; private set; }
        public DateTime? DateUpdated { get; set; }

        public Todo()
        {
            DateCreated = DateTime.Now;
        }
    }
}