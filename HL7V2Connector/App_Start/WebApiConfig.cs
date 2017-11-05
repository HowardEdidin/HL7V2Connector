#region Information

// Solution:  HL7V2Connector
// HL7V2Connector
// File:  WebApiConfig.cs
// 
// Created: 09/06/2017 : 3:14 PM
// 
// Modified By: Howard Edidin
// Modified:  11/05/2017 : 10:50 AM

#endregion

namespace HL7V2Connector
{
    using System.Web.Http;
    using Formatters;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Formatters.Clear();
            config.Formatters.Add(new StringFormateer());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new {id = RouteParameter.Optional}
            );
        }
    }
}