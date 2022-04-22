using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.WebMVC.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync movieService;
        IMovieCastService movieCastService;
        public MovieController(IMovieServiceAsync ser, IMovieCastService service)
        {
            movieService = ser;
            movieCastService = service;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Movies";

           // var result =await movieService.GetTop10RevenueMoviesAsync();

            return View();
        }

        public async Task<IActionResult> Detail(int movieId)
        { 
            var result =await movieService.GetByIdAsync(movieId);
            result.MovieCasts= await movieCastService.GetAllByMovieId(movieId);
            return View(result);
        }

    }
}
