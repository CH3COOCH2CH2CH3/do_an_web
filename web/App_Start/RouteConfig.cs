using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace web
{
    // App_Start/RouteConfig.cs
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "WatchDetails",
                url: "Watches/Details/{id}",
                defaults: new { controller = "Watches", action = "Details", id = 1 } // Giá trị mặc định cho ID
            );
        }
    }
}
