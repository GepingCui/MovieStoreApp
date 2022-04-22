using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreServiceAsync genreServiceAsync;
        public GenreController(IGenreServiceAsync _genreServiceAsync)
        {
            this.genreServiceAsync = _genreServiceAsync;
        }


        [HttpGet]
        [Route("{id:int}/Get10")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await genreServiceAsync.GetAllByGenre(id));
        }

        [HttpGet]
        [Route("{id:int}/GetName")]
        public async Task<IActionResult> GetName(int id)
        {
            return Ok(await genreServiceAsync.GetGenreName(id));
        }

    }
}
