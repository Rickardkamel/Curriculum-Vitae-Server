﻿using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using Owin;

namespace Curriculum_Vitae_server
{
    public class WebApiConfig
    {
        //public static void Configure(IAppBuilder app)
        //{
        //    var config = new HttpConfiguration();
        //    config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

        //    // Web API routes
        //    config.MapHttpAttributeRoutes();
        //    config.Routes.MapHttpRoute(
        //        name: "DefaultApi",
        //    routeTemplate: "api/{controller}/{id}",
        //    defaults: new { id = RouteParameter.Optional });

        //    // Json formatter
        //    config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        //    config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;


        //    app.UseWebApi(config);
        //}

        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }
    }
}
