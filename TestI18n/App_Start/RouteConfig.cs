﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TestI18n
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{lang}/{controller}/{action}/{id}",
            //    defaults: new
            //    {
            //        lang = "zh-TW",
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }
            //);
        }
    }
}