﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();
            // can use this or attribute route directly in controller
          /*  routes.MapRoute(
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new {controller="Movies",action="ByReleaseDate" },
                new { year=@"\d{4}",month= @"\d{2}"}
                );
                */
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
