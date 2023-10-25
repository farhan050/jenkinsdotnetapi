using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateUser([FromBody] string Username)
        {
            return Ok(Username);
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            return Ok("Farhan");
        }
        [HttpGet]
        public IActionResult GetUserbyid([FromQuery] int id)
        {
            return Ok("Farhan");
        }
        [HttpPut]
        public IActionResult UpdateUserbyid([FromQuery] int id)
        {
            return Ok("Hello");
        }
        [HttpDelete]
        public IActionResult deleteUserbyid([FromQuery] int id)
        {
            return Ok("Hello");
        }


    }
}
