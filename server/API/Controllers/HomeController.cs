using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet("GetHi")]
        public IActionResult Get()
        {
            return Ok("Hi");
        }
    }
}
