using Microsoft.Owin;
using System.Threading.Tasks;

namespace Presentation.OwinSample.Middlewares
{
    public class ChangeResponseMiddleware : OwinMiddleware
    {
        public ChangeResponseMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public async override Task Invoke(IOwinContext context)
        {
            if (context.Request.Uri.AbsolutePath.Contains("home"))
            {
                //log something for instance
                return;
            }

            await Next.Invoke(context);
        }
    }
}