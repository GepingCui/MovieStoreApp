using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.WebMVC.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class GenreController : Controller
    {
        IGenreServiceAsync Genre;
        public GenreController(IGenreServiceAsync _G)
        {
            Genre = _G;
        }

        public async Task<IActionResult> Index(int genreId)
        {
            ViewBag.Title = await Genre.GetGenreName(genreId);
            var result= await Genre.GetAllByGenre(genreId);
            return View(result);
        }
    }
}

