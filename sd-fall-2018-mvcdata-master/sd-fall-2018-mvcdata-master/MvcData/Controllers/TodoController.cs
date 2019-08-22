using MvcData.Models.Domain;
using MvcData.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcData.Controllers
{
    public class TodoController : Controller
    {
        public static List<Todo> TodoInMemoryDatabase { get; set; } 
            = new List<Todo>();
        
        public ActionResult Index()
        {
            var viewModel = TodoInMemoryDatabase.Select(
                todo => new IndexTodoViewModel
                {
                    Title = todo.Title,
                    Description = todo.Description,
                    DueDate = todo.DueDate,
                    DateCreated = todo.DateCreated
                }).ToList();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateTodoViewModel
            formData)
        {
            //Example of a server side validation only
            //Goes to the database first and
            //check if the task is duplicated by Title
            //Some code here that we haven't learned.
            //var isTaskDuplicated = true;

            //if (isTaskDuplicated)
            //{
            //    ModelState.AddModelError(nameof(CreateTodoViewModel.Title),
            //    "This task already exists");
            //}

            //ModelState.AddModelError("", "Generic erro happened");

            if (!ModelState.IsValid)
            {
                return View();
            }

            //creating a todo
            var newTodo = new Todo();
            newTodo.Id = 1;
            newTodo.Title = formData.Title;
            newTodo.Description = formData.Description;
            newTodo.DueDate = formData.DueDate;

            //saving to the database
            TodoInMemoryDatabase.Add(newTodo);

            //Redirect the user to the todo list
            return Redirect(nameof(TodoController.Index));
        }
    }
}