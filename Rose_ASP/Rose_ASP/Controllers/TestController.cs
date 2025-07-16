using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Rose_ASP.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet(Name = "Test")]
        public string Get()
        {
            return "Hello world";
        }

        [HttpGet(Name = "LoadData")]
        public string LoadData()
        {
            return "Hello world";
        }
    }
}
