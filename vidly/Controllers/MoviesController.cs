using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        [Route("Movie")]
        public ActionResult MovieList()
        {
            var movie = GetMovies();
            return View(movie);
        }

        [Route("Movies/Details/{id}")]
        public ActionResult MovieDetail(int id)
        {
            var movie = GetMovies().SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customer = new List<Customer>
            {
                new Customer{ Name="Customer 1 "},
                new Customer{ Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customer
            };
            return View(viewModel);
        }

      /*  public ActionResult Edit(int id)
        {
            return Content("Id= "+ id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex= {0}&sortBy= {1}",pageIndex,sortBy));
        }*/

            //attribute routing
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(string.Format("Year= {0}&Month= {1}",year,month));
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
               new Movie{ Id=1,Name="Avangers" },
               new Movie{ Id=2,Name="Thor" }
            };
        }
    }
}