using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("message")]
        public string GetWelcomeMessage()
        {
            return "Welcome to web api";
        }
        [HttpGet]
        [Route("countryname")]
        [Route("getcountry")]
        public string GetCountryName()
        {
            return "USA";
        }

        [Route("Name")]
        public string GetName(string name,string user, int id)
        {
            return "Hi "+name;
        }
        
    }
}
