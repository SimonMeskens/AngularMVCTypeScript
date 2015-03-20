using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using T4TS;

namespace AngularMVCTypeScript.Features.Home
{
    [TypeScriptInterface]
    public class HomeViewModel
    {
        public string HelloAngular { get; set; }
    }
}