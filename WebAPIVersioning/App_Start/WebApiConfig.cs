using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebAPIVersioning
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "V1Route",
                routeTemplate: "api/v1/{controller}/{id}",
                defaults: new { controller = "EmployeeV1", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "V2Route",
                routeTemplate: "api/v2/{controller}/{id}",
                defaults: new { controller = "EmployeeV2", id = RouteParameter.Optional }
            );
        }
    }
}
