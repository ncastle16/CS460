﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Lab7
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GetUser",
                url: "api/user",
                defaults: new { controller = "Home", action = "GetUser" }
                );

            routes.MapRoute(
                name: "GetCommits",
                url: "api/commits",
                defaults: new { controller = "Home", action = "GetCommits", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name: "GetRepos",
                url: "api/repositories",
                defaults: new { controller = "Home", action = "GetRepos" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
