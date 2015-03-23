using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AngularMVCTypeScript.Core;

namespace AngularMVCTypeScript
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var razorEngine = ViewEngines.Engines.OfType<RazorViewEngine>().First();
            var featureFolders = new[]
            {
                "~/Features/{1}/{0}.cshtml",
                "~/Features/{1}/{0}.vbhtml",
                "~/Features/Shared/{0}.cshtml",
                "~/Features/Shared/{0}.vbhtml"
            };

            razorEngine.ViewLocationFormats = featureFolders;
            razorEngine.MasterLocationFormats = featureFolders;
            razorEngine.PartialViewLocationFormats = featureFolders;

            razorEngine.AreaViewLocationFormats = featureFolders;
            razorEngine.AreaMasterLocationFormats = featureFolders;
            razorEngine.AreaPartialViewLocationFormats = featureFolders;

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
