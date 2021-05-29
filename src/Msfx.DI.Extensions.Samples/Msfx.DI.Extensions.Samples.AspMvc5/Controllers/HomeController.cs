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
        [AutoInject]
        public HomeService homeService;
        public ActionResult Index()
        {
            string serviceData = this.homeService.GetData();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}