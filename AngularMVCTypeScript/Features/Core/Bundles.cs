using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Links
{
    public static partial class Bundles
    {
        private const string featureDirectory = "~/Features";
        private const string applicationBundlePath = "~/bundles/Application";
        public const string CDNBasePath = "https://cdnjs.cloudflare.com/ajax/libs/";

        public static readonly IList<Bundle> ScriptLibraryBundles =
            new Bundle[] {
                new ScriptBundle(Links.Bundles.Scripts.libs.jquery.Assets.BundlePath, 
                    CDNBasePath + "jquery/2.1.3/jquery.min.js")
                .Include(Links.Bundles.Scripts.libs.jquery.Assets.jquery_2_1_3_js),

                new ScriptBundle(Links.Bundles.Scripts.libs.angularjs.Assets.BundlePath + "/angular", 
                    CDNBasePath + "angular.js/1.3.14/angular.min.js")
                .Include(Links.Bundles.Scripts.libs.angularjs.Assets.angular_js),

                new ScriptBundle(Links.Bundles.Scripts.libs.angularjs.Assets.BundlePath + "/angular-route", 
                    CDNBasePath + "angular.js/1.3.14/angular-route.min.js")
                .Include(Links.Bundles.Scripts.libs.angularjs.Assets.angular_route_js),

                new ScriptBundle(Links.Bundles.Scripts.libs.ngremotevalidate.Assets.BundlePath)
                .Include(Links.Bundles.Scripts.libs.ngremotevalidate.Assets.ngRemoteValidate_0_6_1_js)
            }.ToList();

        public static readonly IList<Bundle> ScriptApplicationBundles =
            new Bundle[] {
                new ScriptBundle(Links.Bundles.Features.Assets.BundlePath)
                .IncludeDirectory(featureDirectory, "*.js", searchSubdirectories: true)
            }.ToList();

        public static readonly IList<Bundle> StyleBundles =
            new Bundle[] {
                //new StyleBundle("~/Content/css")
                //.Include("~/Content/site.css")
            }.ToList();
    }
}