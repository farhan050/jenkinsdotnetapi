using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinsApi.Controllers
{
    [Route("api/[controller]/[action]")]
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
        [HttpGet]
        public IActionResult GetCustomerbyid([FromQuery] int id)
        {
            return Ok("Farhan");
        }


    }
}
