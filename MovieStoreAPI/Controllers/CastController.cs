using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastController : ControllerBase
    {
        private readonly ICastServiceAsync castServiceAsync;
        public CastController(ICastServiceAsync _castServiceAsync)
        {
            this.castServiceAsync = _castServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await castServiceAsync.GetAllCastAsync());

        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await castServiceAsync.GetCastAsync(id));
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> Create( [FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.AddCastAsync(model));
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.DeleteCastAsync(model));
        }

        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] CastModel model)
        {
            return Ok(await castServiceAsync.UpdateCastAsync(model));
        }
    }
}
