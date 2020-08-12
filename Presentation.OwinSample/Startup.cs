using Owin;
using Presentation.OwinSample.Middlewares;
using System.Web.Http;

//Microsoft.Owin.Host.SystemWeb
//Microsoft.AspNet.WebApi.Owin
namespace Presentation.OwinSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use<ChangeResponseMiddleware>();

            app.UseDefaultWebApi();
        }
    }
}














public static class Ext
{
    public static void UseDefaultWebApi(this IAppBuilder app)
    {
        HttpConfiguration config = new HttpConfiguration();

        config.Routes.MapHttpRoute(
            name: "DefaultApi",
            routeTemplate: "{controller}/{id}",
            defaults: new { id = RouteParameter.Optional }
        );

        app.UseWebApi(config);
    }

    public static void Use<T>(this IAppBuilder app)
    {
        app.Use(typeof(T));
    }
}
