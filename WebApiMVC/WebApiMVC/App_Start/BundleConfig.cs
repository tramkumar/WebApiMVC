using System.Web.Optimization;

namespace WebApiMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/bundles/csscontent").Include(
                        "~/Content/Site.css",
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-theme.css"));

            bundles.Add(new ScriptBundle("~/bundles/uiscripts").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/alertBox.js",
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/bootstrap.js"));

            
            BundleTable.EnableOptimizations = true;
        }
    }
}
