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
        


    }
}
