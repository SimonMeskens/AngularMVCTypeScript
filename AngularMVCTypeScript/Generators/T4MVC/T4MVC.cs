﻿// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo. Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
public static partial class MVC
{
    public static AngularMVCTypeScript.Features.Home.HomeController Home = new AngularMVCTypeScript.Features.Home.T4MVC_HomeController();
    public static T4MVC.AccountController Account = new T4MVC.AccountController();
    public static T4MVC.CoreController Core = new T4MVC.CoreController();
    public static T4MVC.SharedController Shared = new T4MVC.SharedController();
}

namespace T4MVC
{
}

namespace T4MVC
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy() { }
        public static Dummy Instance = new Dummy();
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal partial class T4MVC_System_Web_Mvc_ActionResult : System.Web.Mvc.ActionResult, IT4MVCActionResult
{
    public T4MVC_System_Web_Mvc_ActionResult(string area, string controller, string action, string protocol = null): base()
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }
     
    public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    
    public string Controller { get; set; }
    public string Action { get; set; }
    public string Protocol { get; set; }
    public RouteValueDictionary RouteValueDictionary { get; set; }
}



namespace Links
{
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Scripts {
        private const string URLPATH = "~/Scripts";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        public static readonly string _references_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.d.min.js") ? Url("_references.d.min.js") : Url("_references.d.js");
        public static readonly string _references_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/_references.min.js") ? Url("_references.min.js") : Url("_references.js");
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class libs {
            private const string URLPATH = "~/Scripts/libs";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class angularjs {
                private const string URLPATH = "~/Scripts/libs/angularjs";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string angular_mocks_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-mocks.min.js") ? Url("angular-mocks.min.js") : Url("angular-mocks.js");
                public static readonly string angular_route_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-route.min.js") ? Url("angular-route.min.js") : Url("angular-route.js");
                public static readonly string angular_route_min_js = Url("angular-route.min.js");
                public static readonly string angular_route_min_js_map = Url("angular-route.min.js.map");
                public static readonly string angular_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular.min.js") ? Url("angular.min.js") : Url("angular.js");
                public static readonly string angular_min_js = Url("angular.min.js");
                public static readonly string angular_min_js_map = Url("angular.min.js.map");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class jquery {
                private const string URLPATH = "~/Scripts/libs/jquery";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string jquery_2_1_3_intellisense_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.3.intellisense.min.js") ? Url("jquery-2.1.3.intellisense.min.js") : Url("jquery-2.1.3.intellisense.js");
                public static readonly string jquery_2_1_3_js = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery-2.1.3.min.js") ? Url("jquery-2.1.3.min.js") : Url("jquery-2.1.3.js");
                public static readonly string jquery_2_1_3_min_js = Url("jquery-2.1.3.min.js");
                public static readonly string jquery_2_1_3_min_map = Url("jquery-2.1.3.min.map");
            }
        
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class typings {
            private const string URLPATH = "~/Scripts/typings";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class angularjs {
                private const string URLPATH = "~/Scripts/typings/angularjs";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string angular_animate_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-animate.d.min.js") ? Url("angular-animate.d.min.js") : Url("angular-animate.d.js");
                public static readonly string angular_cookies_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-cookies.d.min.js") ? Url("angular-cookies.d.min.js") : Url("angular-cookies.d.js");
                public static readonly string angular_mocks_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-mocks.d.min.js") ? Url("angular-mocks.d.min.js") : Url("angular-mocks.d.js");
                public static readonly string angular_resource_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-resource.d.min.js") ? Url("angular-resource.d.min.js") : Url("angular-resource.d.js");
                public static readonly string angular_route_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-route.d.min.js") ? Url("angular-route.d.min.js") : Url("angular-route.d.js");
                public static readonly string angular_sanitize_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular-sanitize.d.min.js") ? Url("angular-sanitize.d.min.js") : Url("angular-sanitize.d.js");
                public static readonly string angular_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/angular.d.min.js") ? Url("angular.d.min.js") : Url("angular.d.js");
            }
        
            [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
            public static class jquery {
                private const string URLPATH = "~/Scripts/typings/jquery";
                public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
                public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
                public static readonly string jquery_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/jquery.d.min.js") ? Url("jquery.d.min.js") : Url("jquery.d.js");
            }
        
        }
    
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static class Features {
        private const string URLPATH = "~/Features";
        public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
        public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Account {
            private const string URLPATH = "~/Features/Account";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Core {
            private const string URLPATH = "~/Features/Core";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string IBootstrapDataService_d_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/IBootstrapDataService.d.min.js") ? Url("IBootstrapDataService.d.min.js") : Url("IBootstrapDataService.d.js");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Home {
            private const string URLPATH = "~/Features/Home";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
            public static readonly string Home_ts = T4MVCHelpers.IsProduction() && T4Extensions.FileExists(URLPATH + "/Home.min.js") ? Url("Home.min.js") : Url("Home.js");
        }
    
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public static class Shared {
            private const string URLPATH = "~/Features/Shared";
            public static string Url() { return T4MVCHelpers.ProcessVirtualPath(URLPATH); }
            public static string Url(string fileName) { return T4MVCHelpers.ProcessVirtualPath(URLPATH + "/" + fileName); }
        }
    
        public static readonly string Web_config = Url("Web.config");
    }

    
    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public static partial class Bundles
    {
        public static partial class Scripts 
        {
            public static partial class libs 
            {
                public static partial class angularjs 
                {
                    public static class Assets
                    {
                    	public const string BundlePath = "~/bundles/Scripts/libs/angularjs";
                        public const string angular_mocks_js = "~/Scripts/libs/angularjs/angular-mocks.js"; 
                        public const string angular_route_js = "~/Scripts/libs/angularjs/angular-route.js"; 
                        public const string angular_route_min_js = "~/Scripts/libs/angularjs/angular-route.min.js"; 
                        public const string angular_js = "~/Scripts/libs/angularjs/angular.js"; 
                        public const string angular_min_js = "~/Scripts/libs/angularjs/angular.min.js"; 
                    }
                }
                public static partial class jquery 
                {
                    public static class Assets
                    {
                    	public const string BundlePath = "~/bundles/Scripts/libs/jquery";
                        public const string jquery_2_1_3_intellisense_js = "~/Scripts/libs/jquery/jquery-2.1.3.intellisense.js"; 
                        public const string jquery_2_1_3_js = "~/Scripts/libs/jquery/jquery-2.1.3.js"; 
                        public const string jquery_2_1_3_min_js = "~/Scripts/libs/jquery/jquery-2.1.3.min.js"; 
                    }
                }
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Scripts/libs";
                }
            }
            public static partial class typings 
            {
                public static partial class angularjs 
                {
                    public static class Assets
                    {
                    	public const string BundlePath = "~/bundles/Scripts/typings/angularjs";
                    }
                }
                public static partial class jquery 
                {
                    public static class Assets
                    {
                    	public const string BundlePath = "~/bundles/Scripts/typings/jquery";
                    }
                }
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Scripts/typings";
                }
            }
            public static class Assets
            {
            	public const string BundlePath = "~/bundles/Scripts";
                public const string _references_js = "~/Scripts/_references.js"; 
            }
        }
        public static partial class Features 
        {
            public static partial class Account 
            {
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Features/Account";
                }
            }
            public static partial class Core 
            {
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Features/Core";
                }
            }
            public static partial class Home 
            {
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Features/Home";
                    public const string Home_ts = "~/Features/Home/Home.js"; 
                }
            }
            public static partial class Shared 
            {
                public static class Assets
                {
                	public const string BundlePath = "~/bundles/Features/Shared";
                }
            }
            public static class Assets
            {
            	public const string BundlePath = "~/bundles/Features";
            }
        }
    }
}

[GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
internal static class T4MVCHelpers {
    // You can change the ProcessVirtualPath method to modify the path that gets returned to the client.
    // e.g. you can prepend a domain, or append a query string:
    //      return "http://localhost" + path + "?foo=bar";
    private static string ProcessVirtualPathDefault(string virtualPath) {
        // The path that comes in starts with ~/ and must first be made absolute
        string path = VirtualPathUtility.ToAbsolute(virtualPath);
        
        // Add your own modifications here before returning the path
        return path;
    }

    // Calling ProcessVirtualPath through delegate to allow it to be replaced for unit testing
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;

    // Calling T4Extension.TimestampString through delegate to allow it to be replaced for unit testing and other purposes
    public static Func<string, string> TimestampString = System.Web.Mvc.T4Extensions.TimestampString;

    // Logic to determine if the app is running in production or dev environment
    public static bool IsProduction() { 
        return (HttpContext.Current != null && !HttpContext.Current.IsDebuggingEnabled); 
    }
}





#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108

