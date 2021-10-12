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
        // GET: Movies
        public ActionResult MoviesListed()
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie { Name = "Lord of the Rings"},
                new Movie { Name = "The Two Towers"},
                new Movie { Name = "The Return of the King"}
            };

            var viewModel = new ListsViewModel()
            {
                Movies = movieList
            };

           
            return View(viewModel);
        }

    }
}