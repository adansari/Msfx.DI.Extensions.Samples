using Msfx.DI.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Msfx.DI.Extensions.Samples.AspMvc5.Services
{
    [Injectable]
    public class HomeService
    {
        public string GetData()
        {
            return "HomeService.GetData() called";
        }
    }
}