using System.Web.Mvc;

namespace PersonalBox.MVC.Areas.Financeiros
{
    public class FinanceirosAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Financeiros";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Financeiros_default",
                "Financeiros/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}