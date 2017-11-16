using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCTutorials9AM
{
    public class CustomRouteConfig
    {
        public static void LoadRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("test/showmessage");

            //routes.MapRoute(
            //   "Default",
            //   "admin/user/{controller}/{action}/{id}",
            //   new { controller = "test", action = "ShowMessage", id = UrlParameter.Optional },
            //   new { id = "^[0-9]*" }
            //   );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}/{id1}",
                new { controller = "test", action = "ShowMessage", id = UrlParameter.Optional, id1 = UrlParameter.Optional },
                new { id = "^[0-9]*" }
                );
        }
    }
}