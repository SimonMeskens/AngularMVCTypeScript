using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVCTypeScript.Core;

namespace AngularMVCTypeScript.Features.Home
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                HelloAngular = "I work!"
            };

            return View(viewModel);
        }
    }
}