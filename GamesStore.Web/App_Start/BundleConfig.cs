using System.Web;
using System.Web.Optimization;

namespace GamesStore.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Styles
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendor/bootstrap/css/bootstrap.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/fontawesome").Include("~/Vendor/css/fontawesome.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/template").Include("~/Vendor/css/templatemo-lugx-gaming.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/owl").Include("~/Vendor/css/owl.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/animate").Include("~/Vendor/css/animate.css", new CssRewriteUrlTransform()));
            
            //Scripts
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Vendor/jquery/jquery.min.js"));
            bundles.Add(new Bundle("~/bundles/bootstrap").Include("~/Vendor/bootstrap/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/isotope").Include("~/Vendor/js/isotope.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/owl-carousel").Include("~/Vendor/js/owl-carousel.js"));
            bundles.Add(new ScriptBundle("~/bundles/counter").Include("~/Vendor/js/counter.js"));
            bundles.Add(new ScriptBundle("~/bundles/custom").Include("~/Vendor/js/custom.js"));

        }
    }
}
