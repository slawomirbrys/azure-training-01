using NewsApiApp;
using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace NewsApiApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            //// STAGE2 - Odkomentowac
            //GlobalConfiguration.Configuration
            //    .EnableSwagger(c =>
            //        {
            //            c.SingleApiVersion("v1", "NewsApiApp");
            //        })
            //    .EnableSwaggerUi(c =>
            //        {
            //        });
        }
    }
}