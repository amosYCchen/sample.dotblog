using System.Web;
using System.Web.Http;

[assembly: PreApplicationStartMethod(typeof(WebApiNet48.WebApiApplication), "InitModule")]

namespace WebApiNet48
{
    public class WebApiApplication : HttpApplication
    {
        //static WebApiApplication()
        //{
        //    RegisterModule(typeof(ServiceScopeModule));
        //}

        public static void InitModule()
        {
            RegisterModule(typeof(ServiceScopeModule));
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}