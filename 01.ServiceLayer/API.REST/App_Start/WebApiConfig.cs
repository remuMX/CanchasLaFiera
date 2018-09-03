using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;
//Agregamos la libreria Newtonsoft
using Newtonsoft.Json.Serialization;

namespace API.REST
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;

            jsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.None;
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            settings.Formatting = Newtonsoft.Json.Formatting.Indented;

            //
            settings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();


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
