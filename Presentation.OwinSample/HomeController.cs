using System.Web.Http;

namespace Presentation.OwinSample
{
    [Route("[controller]")]
    public class HomeController : ApiController
    {
        public string Get()
        {
            return "Hello From OWIN";
        }
    }
}