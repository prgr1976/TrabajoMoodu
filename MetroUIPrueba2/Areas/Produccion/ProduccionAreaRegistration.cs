using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Produccion
{
    public class ProduccionAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Produccion";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Produccion_default",
                "Produccion/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new [] { "MetroUIPrueba2.Areas.Produccion.Controllers" }
            );
        }
    }
}