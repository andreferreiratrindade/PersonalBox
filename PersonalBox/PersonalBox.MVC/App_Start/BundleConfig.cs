using System.Web;
using System.Web.Optimization;

namespace PersonalBox.MVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
                      "~/Scripts/knockout-{version}.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/gentelella/css").Include(
                     "~/Content/gentelella/css/bootstrap.min.css",
                     "~/Content/gentelella/fonts/css/font-awesome.min.css",
                     "~/Content/gentelella/css/animate.min.css",
                     "~/Content/gentelella/css/custom.css",
                     "~/Content/gentelella/css/icheck/flat/green.css",
                     "~/Content/gentelella/css/editor/external/google-code-prettify/prettify.css",
                     "~/Content/gentelella/css/editor/index.css",
                     "~/Content/gentelella/css/select/select2.min.css",
                     "~/Content/gentelella/css/switchery/switchery.min.css",
                     "~/Content/gentelella/css/editor/index.css"));
         
            // Template Gantella-Master
            bundles.Add(new ScriptBundle("~/bundles/gentelella").Include(
                "~/Scripts/template/gentelella-master/js/bootstrap.min.js", 
                "~/Scripts/template/gentelella-master/js/tags/jquery.tagsinput.min.js",
                "~/Scripts/template/gentelella-master/js/switchery/switchery.min.js",
                "~/Scripts/template/gentelella-master/js/moment.min2.js", 
                "~/Scripts/template/gentelella-master/js/datepicker/daterangepicker.js",
                "~/Scripts/template/gentelella-master/js/parsley/parsley.min.js",
                "~/Scripts/template/gentelella-master/js/textarea/autosize.min.js",
                "~/Scripts/template/gentelella-master/js/autocomplete/jquery.autocomplete.js",
                "~/Scripts/template/gentelella-master/js/custom.js"
                ));
            /*

        < script src = "js/bootstrap.min.js" ></ script >
 
         < !--chart js-- >
         < script src = "js/chartjs/chart.min.js" ></ script >
          
            < !--bootstrap progress js -->
          < script src = "js/progressbar/bootstrap-progressbar.min.js" ></ script >
           < script src = "js/nicescroll/jquery.nicescroll.min.js" ></ script >
           
            < !--icheck-- >
            < script src = "js/icheck/icheck.min.js" ></ script >
            
            < !--tags-- >
             < script src = "js/tags/jquery.tagsinput.min.js" ></ script >
             
            < !--switchery-- >
              < script src = "js/switchery/switchery.min.js" ></ script >
             
            < !--daterangepicker-- >
               < script type = "text/javascript" src = "js/moment.min2.js" ></ script >
                  < script type = "text/javascript" src = "js/datepicker/daterangepicker.js" ></ script >
                   
            < !--richtext editor-- >
                     < script src = "js/editor/bootstrap-wysiwyg.js" ></ script >
                      < script src = "js/editor/external/jquery.hotkeys.js" ></ script >
                       < script src = "js/editor/external/google-code-prettify/prettify.js" ></ script >
                     
            < !--select2-- >
                        < script src = "js/select/select2.full.js" ></ script >
                       
            < !--form validation-- >
                         < script type = "text/javascript" src = "js/parsley/parsley.min.js" ></ script >
                       
            < !--textarea resize-- >
                            < script src = "js/textarea/autosize.min.js" ></ script >
*/
        }
    }
}
