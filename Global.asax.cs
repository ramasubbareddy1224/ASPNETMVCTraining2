﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVCTutorials9AM
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            CustomRouteConfig.LoadRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            CustomBundleConfig.RegisterBundle(BundleTable.Bundles);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
