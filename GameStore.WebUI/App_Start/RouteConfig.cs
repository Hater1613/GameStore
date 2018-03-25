using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace GameStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GetAllGames",
                url: "games",
                defaults: new { controller = "Game", action = "GetAllGames" }
            );
            routes.MapRoute(
                name: "SmallCaps1",
                url: "games/{action}/{id}",
                defaults: new { controller = "Game", action = "GetAllGames", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "SmallCaps2",
                url: "game/{action}/{id}",
                defaults: new { controller = "Game", action = "GetAllGames", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Game", action = "GetAllGames", id = UrlParameter.Optional }
            );
        }
    }
}