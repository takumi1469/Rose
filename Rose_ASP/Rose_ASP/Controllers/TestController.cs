using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Rose_ASP.Controllers
{
    [Route("api")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Test")]
        public string Get()
        {
            return "Hello world";
        }

        [HttpGet("LoadData")]
        public string LoadData()
        {
            return "Hello world";
        }
    }
}
