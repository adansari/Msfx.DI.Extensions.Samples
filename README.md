# Msfx.DI.Extensions.Samples

## Asp.net MVC 5

Download the binaries from [here](https://github.com/adansari/Msfx.DI.Extensions.Samples/tree/main/src/Msfx.DI.Extensions.Samples/Msfx.DI.Extensions.Samples.AspMvc5/Libs)

Add below entry in the `Global.asax.cs`
```csharp
  ControllerBuilder.Current
      .SetControllerFactory(
          new DIControllerFactory(
              new AttributeBasedDIContext(
                  typeof(HomeController) // This should be any controller or class from current assembly
                  , Scanners.DependencyScanTarget.Assembly)
              .Scan()));
```
Now in your controller, there is no need to inject / and instantiate any dependency

```csharp

using Msfx.DI.Attributes;
using Msfx.DI.Extensions.Samples.AspMvc5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Msfx.DI.Extensions.Samples.AspMvc5.Controllers
{
    public class HomeController : Controller
    {
        [AutoInject] // <- Add this attribute
        public HomeService homeService; // This service class will be injected automatically
        public ActionResult Index()
        {
            string serviceData = this.homeService.GetData(); // using the service class
            return View();
        }
    }
}
```
