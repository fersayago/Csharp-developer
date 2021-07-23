using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Ejemplo1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            // removemos el XML de los formatos para que devuelva JSON
            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter)
            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
