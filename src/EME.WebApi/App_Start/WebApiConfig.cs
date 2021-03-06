﻿using System.Web.Http;
using EME.Application.Filters.Api;

namespace EME.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Filters.Add(new HandleExceptionAttribute());
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}