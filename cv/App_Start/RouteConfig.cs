using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cv
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("HOME","" ,new{controller = "Post", action = "Index"});
            routes.MapRoute("İndex", "index", new{ controller = "Post", action = "Index" });
            routes.MapRoute("info", "info", new { controller = "info", action = "info" });
            routes.MapRoute("Contact", "Contact", new { controller = "Contact", action = "Contact" });
            routes.MapRoute("education", "education", new { controller = "education", action = "education" });
            routes.MapRoute("language", "language", new { controller = "language", action = "language" });
            routes.MapRoute("certificate", "certificate", new { controller = "certificate", action = "certificate" });





        }
    }
}
