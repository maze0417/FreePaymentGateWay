using System.Data.Entity.Infrastructure;
using EME.Infrastructure.Common.Configurations;

namespace EME.Data.SqlRepositories
{
    public class DbRepositoryFactory : IDbContextFactory<DbRepository>
    {
        public DbRepository Create()
        {
            return new DbRepository(new DataConfig());
        }
    }
}