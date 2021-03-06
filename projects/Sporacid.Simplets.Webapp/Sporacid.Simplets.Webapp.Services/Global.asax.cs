﻿namespace Sporacid.Simplets.Webapp.Services
{
    using System.Web.Http;

    //using System.Web.Mvc;

    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            AutoFacConfig.Register(GlobalConfiguration.Configuration);
            SerializationConfig.Register(GlobalConfiguration.Configuration);
            AutoMapperConfig.Register(GlobalConfiguration.Configuration);
            SecurityConfig.Register(GlobalConfiguration.Configuration);
            GlobalConfiguration.Configuration.EnsureInitialized();
        }
    }
}