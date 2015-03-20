// <auto-generated />
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

namespace System.Web.Mvc {
    [GeneratedCode("T4MVC", "2.0")]
    public static class HtmlHelpersForExplicitPartials
    {
     
        ///<summary>
        ///Render the <b>_Layout</b> partial.
        ///</summary>
        public static void Render_Layout(this HtmlHelper html) {
            html.RenderPartial("~/Features/Shared/_Layout.cshtml");
        }
        
        ///<summary>
        ///Render the <b>_Layout</b> partial.
        ///</summary>
        public static void Render_Layout(this HtmlHelper html, object model) {
            html.RenderPartial("~/Features/Shared/_Layout.cshtml", model);
        }
     
    }
}
#endregion T4MVC
#pragma warning restore 1591, 3008, 3009, 0108
