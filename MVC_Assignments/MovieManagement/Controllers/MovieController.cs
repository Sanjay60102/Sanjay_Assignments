using Microsoft.AspNetCore.Mvc;
using MovieManagement.Models;

namespace MovieManagement.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository;
        public MovieController() 
        {
            movieRepository = new MovieRepository();
        }
        public IActionResult Index()
        {
            //Get all movies
            var movies = movieRepository.GetAllMovies();
            return View(movies);
        }
        public IActionResult Detail(string Title)
        {
            var movie = movieRepository.GetMovie(Title);
            return View(movie);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Add(Movie movie)
        {
            movieRepository.Add(movie);
            return RedirectToAction("Index");
        }
    }
}
