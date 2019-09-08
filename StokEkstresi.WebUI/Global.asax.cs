using StokEkstresi.WebUI.Controllers;
using StokEkstresi.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace StokEkstresi.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //eğer datetime tipi görürsen kendininkini geç bizimkini hayata geçir
            ModelBinders.Binders.Add(typeof(DateTime), new DateTimeModelBinder());
        }
       
    }
}
