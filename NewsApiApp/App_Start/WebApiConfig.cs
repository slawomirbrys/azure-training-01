using NewsCommon.Models;
using NewsCommon.Other;
using System.Configuration;
using System.Web.Http;

namespace NewsApiApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            //// STAGE3 - Odkomentowac oraz skonfigurowac klucze ddb* w https://portal.azure.com
            DocumentDbRepository<News>.Initialize(
                ConfigurationManager.AppSettings["ddbEndpoint"],
                ConfigurationManager.AppSettings["ddbAuthKey"],
                ConfigurationManager.AppSettings["ddbDatabase"],
                ConfigurationManager.AppSettings["ddbCollection"]
                );

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
