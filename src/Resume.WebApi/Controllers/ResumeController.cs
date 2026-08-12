using Microsoft.AspNetCore.Mvc;

namespace Resume.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class ResumeController : Controller
    {
        [HttpGet]
        [HttpGet("/")]
        [HttpGet("/[controller]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
