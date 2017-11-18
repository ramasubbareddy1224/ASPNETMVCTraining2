using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCTutorials9AM
{
    public class CustomBundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            StyleBundle styles = new StyleBundle("~/Content/css");
            styles.Include("~/Content/bootstrap.css", "~/Content/Site.css");

            bundles.Add(styles);

            ScriptBundle scripts = new ScriptBundle("~/Scripts/script");
            scripts.Include("~/Scripts/jquery-{version}.js",
                            "~/Scripts/jquery.validate*",
                            "~/Scripts/modernizr-*",
                            "~/Scripts/bootstrap.js"
                );

            bundles.Add(scripts);

        }
    }
}