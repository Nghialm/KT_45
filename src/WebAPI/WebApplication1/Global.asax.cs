using Spring.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace WebApplication1
{
    public class WebApiApplication : SpringMvcApplication
    {
        protected void Application_Start()
        {
            // More config...
            GlobalConfiguration.Configure(WebApiConfig.Register);
            // More config...
        }
        
        //protected override System.Web.Http.Dependencies.IDependencyResolver  BuildWebApiDependencyResolver()
        //{
        //    var resolver = base.BuildWebApiDependencyResolver();

        //    var springResolver = resolver as SpringWebApiDependencyResolver;

        //    if (springResolver != null)
        //    {
        //        var resource = new AssemblyResource(
        //            "assembly://assemblyName/namespace/ChildControllers.xml");
        //        springResolver.AddChildApplicationContextConfigurationResource(resource);
        //    }

        //    return resolver;
        //}
    }
}
