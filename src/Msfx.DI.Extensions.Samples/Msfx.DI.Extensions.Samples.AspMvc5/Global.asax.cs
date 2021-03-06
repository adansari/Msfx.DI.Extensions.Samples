using Msfx.DI.Extensions.AspMvc5;
using Msfx.DI.Extensions.Samples.AspMvc5.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Msfx.DI.Extensions.Samples.AspMvc5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ControllerBuilder.Current
                .SetControllerFactory(
                    new DIControllerFactory(
                        new AttributeBasedDIContext(
                            typeof(HomeController)
                            , Scanners.DependencyScanTarget.Assembly)
                        .Scan()));
        }
    }
}
