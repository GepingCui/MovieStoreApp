using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
namespace MovieStoreApp.WebMVC.Component
{
    public class LatestMovieViewComponent:ViewComponent
    {
        IMovieServiceAsync movieService;
        public LatestMovieViewComponent(IMovieServiceAsync ser)
        {
            movieService = ser;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await movieService.GetTop3LatestMoviesAsync();
            return View("latestmovie",result);
        }
    }
}
