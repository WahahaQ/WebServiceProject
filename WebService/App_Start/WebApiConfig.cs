﻿using System.Web.Http;

namespace WebService
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}