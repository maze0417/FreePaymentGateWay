using EME.Application.Interfaces;
using EME.Application.Services;
using EME.Data.SqlRepositories;
using EME.Infrastructure.Common.Configurations;
using Microsoft.Practices.Unity;

namespace EME.Application.Factory
{
    public static class UnityFactory
    {
        private static LifetimeManager NewEachTime => new PerResolveLifetimeManager();
        private static LifetimeManager ReuseWithinContainer => new ContainerControlledLifetimeManager();

        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserService, UserService>(NewEachTime);
            container.RegisterType<IDbRepository, DbRepository>(NewEachTime);
            container.RegisterType<IDataConfig, DataConfig>(ReuseWithinContainer);

            return container;
        }
    }
}