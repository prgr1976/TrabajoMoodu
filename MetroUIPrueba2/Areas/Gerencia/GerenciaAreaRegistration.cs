using System.Web.Mvc;

namespace MetroUIPrueba2.Areas.Gerencia
{
    public class GerenciaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Gerencia";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Gerencia_default",
                "Gerencia/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"MetroUIPrueba2.Areas.Gerencia.Controllers"}
            );
        }
    }
}