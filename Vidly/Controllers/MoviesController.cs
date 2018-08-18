using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> { new Movie { Name = "Dilwale Dulhania Le Jayenge!!" }, new Movie { Name = "Dil Se.." } };
        }

        // GET: Movies/Random
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    var customers = new List<Customer> {
        //        new Customer { Name="Customer 1" },
        //        new Customer { Name="Customer 2" }
        //    };

        //    var viewModel = new RandomViewModel() { Movie = movie, Customers = customers };
        //    return View(viewModel);

        //    ////return Content("Hello World !");
        //    ////return HttpNotFound();
        //    ////return new EmptyResult();
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortb = "name" });
        //}

        //// GET: Movies/Edit
        //public ActionResult Edit(int movieId)
        //{
        //    return Content(String.Format("Id = {0}", movieId));
        //}

        //// GET: Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if(!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";

        //    return Content(String.Format("Page Index = {0} & SortBy = {1}", pageIndex, sortBy));
        //}

        //[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}:range(1,12))}")]
        //public ActionResult ByReleaseDate(int year, byte month)
        //{
        //    return Content(year + "/" + month);
        //}

        
    }
}