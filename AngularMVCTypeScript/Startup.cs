using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularMVCTypeScript.Startup))]
namespace AngularMVCTypeScript
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
