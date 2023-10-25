using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateCustomer([FromBody] string Customername)
        {
            return Ok(Customername);
        }
        [HttpGet]
        public IActionResult GetCustomer()
        {
            return Ok("Farhan");
        }

        
    }
}
