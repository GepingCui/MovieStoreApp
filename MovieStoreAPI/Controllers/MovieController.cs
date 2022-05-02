using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServiceAsync movieServiceAsync;
        public MovieController(IMovieServiceAsync _movieServiceAsync)
        {
            this.movieServiceAsync = _movieServiceAsync;
        }

        [HttpGet]
        [Route("Top")]
        public async Task<IActionResult> Get()
        {
            return Ok(await movieServiceAsync.GetTop3LatestMoviesAsync());

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await movieServiceAsync.GetByIdAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create([FromBody] MovieResponseModel model)
        {
            return Ok(await movieServiceAsync.AddMovieAsync(model));
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            return Ok(await movieServiceAsync.DeleteMovieAsync(Id));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] MovieResponseModel model)
        {
            return Ok(await movieServiceAsync.UpdateMovieAsync(model));
        }


    }
}
