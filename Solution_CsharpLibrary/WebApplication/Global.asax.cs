using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using WebApplication.CustomViewEngines;

namespace WebApplication
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            // Remove X-AspNetMvc-Version from the response header
            MvcHandler.DisableMvcResponseHeader = true;

            // Don't add required field attributes to hidden fields
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Optimise ViewEngines
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CSharpOnlyViewEngine());
        }

        protected void Application_PreSendRequestHeaders()
        {
            // Remove response header
            Response.Headers.Remove("X-AspNetMvc-Version");
            Response.Headers.Remove("X-AspNet-Version");
        }
    }
}