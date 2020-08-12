using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Presentation.AspCore.Middlewares;

namespace Presentation.AspCore
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseOwinApp(owinApp =>
            {
                owinApp.Use<ChangeResponseMiddleware>();
            });


            app.UseDefaultApiCore();
        }
    }
}
