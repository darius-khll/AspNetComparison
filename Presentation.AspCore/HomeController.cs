using Microsoft.AspNetCore.Mvc;

namespace Presentation.AspCore
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public string Get()
        {
            return "Hello From Core";
        }
    }
}