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
        public static List<Todo> TodoInMemoryDatabase { get; set; } = new List<Todo>();
        // GET: Todo
        public ActionResult Index()
        {
            return View(TodoInMemoryDatabase);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(CreateTodoViewModel formData)
            //public ActionResult SaveTodo(CreateTodoViewModel formData)
        {
            //
            //Goes to the database first and check if the task is duplicated bu Title some code here that we havent learned
            var isTaskDuplicated = true;
            if (isTaskDuplicated) {
                ModelState.AddModelError(nameof(CreateTodoViewModel.Title), " This Title is exist!");
                    }
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
            
            return null;
        }

        //[HttpPost]
        //public ActionResult Create(CreateTodoViewModel model)
        ////public ActionResult Create(CreateTodoViewModel formData)
        //{
        //    //use require to relize
        //    //if (string.IsNullOrWhiteSpace(model.Description))
        //    //{
        //    //}
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    //creating a todo
        //    var newTodo = new Todo();
        //    newTodo.Id = 1;
        //    newTodo.Title = model.Title;
        //    newTodo.Description = model.Description;
        //    newTodo.DueDate = model.DueDate;

        //    //saving to the database
        //    return null;
        //}

        //public ActionResult Create(string description, string title, DateTime dueDate)
        //{
        //    var newTodo = new Todo();
        //    newTodo.Id = 1;
        //    newTodo.Title = title;
        //    newTodo.Description = description;
        //    newTodo.DueDate = dueDate;
        //    return null;
        //}
    }
}