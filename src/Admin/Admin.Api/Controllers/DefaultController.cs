using Microsoft.AspNetCore.Mvc;

namespace Admin.Api.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class DefaultController : ControllerBase
    {
       [HttpGet]
        public string Get()
        {
            return "Running...";
        }
    }
}