using System.Web;
using System.Web.Optimization;

namespace AngularMVCTypeScript
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            foreach (var scriptLibraryBundle in Links.Bundles.ScriptLibraryBundles)
            {
                bundles.Add(scriptLibraryBundle);
            }

            foreach (var scriptApplicationBundle in Links.Bundles.ScriptApplicationBundles)
            {
                bundles.Add(scriptApplicationBundle);
            }

            foreach (var styleBundle in Links.Bundles.StyleBundles)
            {
                bundles.Add(styleBundle);
            }
        }
    }
}
