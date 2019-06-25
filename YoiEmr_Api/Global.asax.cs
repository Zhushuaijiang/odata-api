using System.Web.Http;
using System.Web.Http.Cors;

namespace YoiEmr_Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //
            var cors = new EnableCorsAttribute("*", "*", "*");
            GlobalConfiguration.Configuration.EnableCors(cors);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
          
        }
    }
}
