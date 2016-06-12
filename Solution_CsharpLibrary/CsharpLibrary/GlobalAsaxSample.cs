namespace CsharpLibrary
{
    public class GlobalAsaxSample
    {
        protected void Application_Start()
        {
            // Remove X-AspNetMvc-Version from the response header
            //MvcHandler.DisableMvcResponseHeader = true;

            // Don't add required field attributes to hidden fields
            //DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;

            //AreaRegistration.RegisterAllAreas();

            //WebApiConfig.Register(GlobalConfiguration.Configuration);
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Optimise ViewEngines
            //ViewEngines.Engines.Clear();
            //ViewEngines.Engines.Add(new CSharpOnlyViewEngine());
        }

        protected void Application_PreSendRequestHeaders()
        {
            // Remove response header
            //Response.Headers.Remove("X-AspNetMvc-Version");
            //Response.Headers.Remove("X-AspNet-Version");
        }
    }
}
