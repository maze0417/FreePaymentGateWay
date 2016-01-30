using System.Web.Http;
using FreePayment.Core.Infrastructure.UnityConfigs;
using Unity.WebApi;

namespace FreePayment.Data.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(config
                => config.DependencyResolver = new UnityDependencyResolver(DataApiUnityConfig.RegisterComponents()));
        }
    }
}