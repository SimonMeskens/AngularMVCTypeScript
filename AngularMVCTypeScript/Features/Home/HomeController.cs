using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AngularMVCTypeScript.Core;

namespace AngularMVCTypeScript.Features.Home
{
    [RoutePrefix("Home")]
    public partial class HomeController : Controller
    {
        [Route]
        [Route("~/", Name = "Landing")]
        public virtual ActionResult Index()
        {
            var viewModel = new HomeViewModel()
            {
                HelloAngular = "I work!"
            };

            return View(viewModel);
        }

        [HttpPost]
        [Route("Validate")]
        public virtual ActionResult Validate(string value)
        {
            if (value.Contains('o'))
                return Json(new { isValid = false, value = "O's are evil!"});

            return Json(new { isValid = true, value = "Perfectly fine." });
        }
    }
}