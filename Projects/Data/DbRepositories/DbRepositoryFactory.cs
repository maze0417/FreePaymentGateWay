using System.Data.Entity.Infrastructure;
using FreePayment.Core.Configurations;

namespace FreePayment.Data.DbRepositories
{
    public class DbRepositoryFactory : IDbContextFactory<DbRepository>
    {
        public DbRepository Create()
        {
            return new DbRepository(new DataConfig());
        }
    }
}