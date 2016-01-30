using FreePayment.Core.Configurations;
using FreePayment.Core.Interfaces;
using FreePayment.Core.Interfaces.DbRepositories;
using FreePayment.Core.Interfaces.DbRepositories.Queries;
using FreePayment.Data.DbRepositories;
using FreePayment.Data.DbRepositories.Queries;
using Microsoft.Practices.Unity;

namespace FreePayment.Core.Infrastructure.UnityConfigs
{
    public static class DataApiUnityConfig
    {
        private static LifetimeManager NewEachTime { get { return new PerResolveLifetimeManager(); } }
        private static LifetimeManager ReuseWithinContainer { get { return new ContainerControlledLifetimeManager(); } }

        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserQueries, UserQueries>(NewEachTime);
            container.RegisterType<IDbRepository, DbRepository>(NewEachTime);
            container.RegisterType<IDataConfig, DataConfig>(ReuseWithinContainer);

            return container;
        }
    }
}