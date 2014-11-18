using System.Web.Mvc;

namespace Harris.Web.Areas.HPRS
{
    public class HPRSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HPRS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HPRS_default",
                "HPRS/{controller}/{action}/{id}",
                new { action = "Index", controller = "Home", id = UrlParameter.Optional }
            );
        }
    }
}