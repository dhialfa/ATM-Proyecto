﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_AnalisisArchivos
{
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
                name: "Login",
                url: "Login/Login",
                defaults: new { controller = "Login", action = "Login" }
        );
            routes.MapRoute(
               name: "MainView",
               url: "MainView/MainView",
               defaults: new { controller = "MainView", action = "MainView" }
       );
        }
    }
}
