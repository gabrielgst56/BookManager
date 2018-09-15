using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace HBSIS.BookManager
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            GlobalConfiguration.Configuration.Formatters
                 .JsonFormatter.SerializerSettings
                 .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            GlobalConfiguration.Configuration.Formatters.
                         XmlFormatter.SupportedMediaTypes.Clear();

            GlobalConfiguration.Configuration.Formatters
                .Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter);

            GlobalConfiguration.Configuration.Formatters
                .Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);

            GlobalConfiguration.Configuration.EnsureInitialized();

            GlobalConfiguration.Configuration.Formatters.JsonFormatter
                .SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter
                .SerializerSettings.NullValueHandling
                = Newtonsoft.Json.NullValueHandling.Ignore;

            GlobalConfiguration.Configuration.Formatters.JsonFormatter
                .SerializerSettings.DateFormatHandling
                = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
        }
    }
}
