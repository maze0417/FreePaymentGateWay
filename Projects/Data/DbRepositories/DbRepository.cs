using System;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using FreePayment.Core.Interfaces;
using FreePayment.Core.Interfaces.DbRepositories;
using FreePayment.Data.DbRepositories.Migrations;
using FreePayment.Data.DbRepositories.TableMaps;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Data.DbRepositories
{
    public class DbRepository : DbContext, IDbRepository
    {
        private static readonly object InitializationLock = new object();
        private static volatile bool _isInitialized;
        private readonly IDataConfig _dataConfig;

        public DbRepository(IDataConfig dataConfig)
            : base("name=" + dataConfig.KeyForConnectionString)
        {
            _dataConfig = dataConfig;

            if (!_isInitialized)
            {
                lock (InitializationLock)
                {
                    if (!_isInitialized)
                    {
                        Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbRepository, DbMigrationsConfig>());
                        _isInitialized = true;
                    }
                }
            }
        }

        #region table

        public virtual IDbSet<Merchant> Merchants { get; set; }

        public virtual IDbSet<DbVersion> DbVersions { get; set; }

        public virtual IDbSet<Localization> Localizations { get; set; }

        public virtual IDbSet<User> Users { get; set; }

        public virtual IDbSet<Payment> Payments { get; set; }

        #endregion table

        bool IDbRepository.HasChanges => ChangeTracker.HasChanges();

        Action<string> IDbRepository.Log
        {
            get { return Database.Log; }
            set { Database.Log = value; }
        }

        DbContextTransaction IDbRepository.BeginTransaction(IsolationLevel isolation)
        {
            return Database.BeginTransaction(isolation);
        }

        void IDbRepository.EnsureDataSeeding()
        {
            throw new NotImplementedException();
        }

        Task<int> IDbRepository.ExecuteSqlCommandAsync(string sql, params object[] args)
        {
            return Database.ExecuteSqlCommandAsync(sql, args);
        }

        void IDbRepository.SetInitialData(long newDbVersion)
        {
            throw new NotImplementedException();
        }

        Task<TEntity[]> IDbRepository.SqlQueryArrayAsync<TEntity>(string sql, params object[] parameters)
        {
            return Database.SqlQuery<TEntity>(sql, parameters).ToArrayAsync();
        }

        void IDbRepository.UpdateData(long oldDbVersion, long newDbVersion)
        {
            throw new NotImplementedException();
        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Configurations.Add(new MerchantMap(_dataConfig));
            mb.Configurations.Add(new UserMap(_dataConfig));
            mb.Configurations.Add(new DbVersionMap(_dataConfig));
            mb.Configurations.Add(new LocalizationMap(_dataConfig));
            mb.Configurations.Add(new LanguageMap(_dataConfig));
            mb.Configurations.Add(new PaymentMap(_dataConfig));
        }
    }
}