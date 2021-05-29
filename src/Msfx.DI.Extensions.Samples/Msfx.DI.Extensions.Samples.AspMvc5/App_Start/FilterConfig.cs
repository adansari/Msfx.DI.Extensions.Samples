using System.Web;
using System.Web.Mvc;

namespace Msfx.DI.Extensions.Samples.AspMvc5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
