using Microsoft.AspNetCore.Mvc;

namespace TrickingLibrary.API.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class Home : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHome()
        {
            return Ok("Welcome to the Home API!");
        }

    }
}
