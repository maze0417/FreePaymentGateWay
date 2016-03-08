using EME.Data.SqlRepositories;
using EME.Infrastructure.Common.Configurations;
using Microsoft.Practices.Unity;

namespace EME.Application.Common.Factory
{
    public static class EmeFactory
    {
        private static LifetimeManager NewEachTime => new PerResolveLifetimeManager();
        private static LifetimeManager ReuseWithinContainer => new ContainerControlledLifetimeManager();

        public static IUnityContainer RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IUserSer, UserQueries>(NewEachTime);
            container.RegisterType<IDbRepository, DbRepository>(NewEachTime);
            container.RegisterType<IDataConfig, DataConfig>(ReuseWithinContainer);

            return container;
        }
    }
}