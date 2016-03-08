using System.Web.Http;
using EME.Application.Factory;
using Unity.WebApi;

namespace EME.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            GlobalConfiguration.Configure(config
                => config.DependencyResolver = new UnityDependencyResolver(UnityFactory.RegisterComponents()));
        }
    }
}