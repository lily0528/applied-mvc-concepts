using Microsoft.AspNet.Identity;
using MvcMovie.Models;
using MvcMovie.Models.Domain;
using MvcMovie.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    //[Authorize(Roles ="Admin,MySpecialRole1")]
    [Authorize(Roles = "Admin")]
    public class MovieController : Controller
    {
        private ApplicationDbContext DbContext;

        public MovieController()
        {
            DbContext = new ApplicationDbContext();
        }
        //private static Random Random = new Random();
        //private static List<Movie> MoviesInMermoryDatabase { get; set; }
        //    = new List<Movie>();
        //private static List<Movie> MoviesInMermoryDatabase = new List<Movie>();
        // GET: Movie

        public ActionResult Index()
        {
            //remember to use using System.Linq;
            //Use viewModels/indexMovieViewModel structure class
            //var UserId = User.Identity.GetUserId();
            var viewModel = DbContext.Movies.Select(
            Movie => new IndexMovieViewModel
            {
                Id = Movie.Id,
                Name = Movie.Name,
                Rating = Movie.Rating,
                Category = Movie.Category,
                CreateDate = Movie.CreateDate
            }).ToList();

            return View(viewModel);

        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //data come from viewModels structment class
        public ActionResult Create(CreateMovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var newMovie = new Movie();
            var userId = User.Identity.GetUserId();
            newMovie.UserId = userId;
            //newMovie.Id = Random.Next(1, 1001);
            newMovie.Name = model.Name;
            newMovie.Rating = model.Rating;
            newMovie.Category = model.Category.ToString();

            newMovie.CreateDate = model.CreateDate;

            //saving to the database
            DbContext.Movies.Add(newMovie);
            DbContext.SaveChanges();
            //Redirect the user to the todo list

            return Redirect(nameof(MovieController.Index));
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var MovieSelect = DbContext.Movies.Where(m => m.Id == id)
                                 .FirstOrDefault();
            //var MovieSelect = MoviesInMermoryDatabase.FirstOrDefault(m => m.Id == id)

            if (MovieSelect == null)
            {
                return Redirect(nameof(MovieController.Index));
            }
            var model = new CreateMovieViewModel();

            return View(MovieSelect);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {

                //write code to update student 

                return RedirectToAction("Index");
            }

            return View(movie);
        }
       
    }
}