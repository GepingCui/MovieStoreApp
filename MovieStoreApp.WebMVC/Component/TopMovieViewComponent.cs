using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;

namespace MovieStoreApp.WebMVC.Component
{
    public class TopMovieViewComponent:ViewComponent
    {
        IMovieServiceAsync movieService;
        public TopMovieViewComponent(IMovieServiceAsync ser)
        {
            movieService = ser;
        }
       
       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await movieService.GetTop10RevenueMoviesAsync();
            return View(result);
            
        }

        
    }
}
