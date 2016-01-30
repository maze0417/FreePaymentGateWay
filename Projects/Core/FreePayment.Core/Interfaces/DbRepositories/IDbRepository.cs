using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Core.Interfaces.DbRepositories
{
    public interface IDbRepository
    {
        #region table

        IDbSet<Merchant> Merchants { get; set; }

        IDbSet<DbVersion> DbVersions { get; set; }

        IDbSet<Localization> Localizations { get; set; }

        IDbSet<User> Users { get; set; }

        IDbSet<Payment> Payments { get; set; }

        #endregion table

        Action<string> Log { get; set; }

        bool HasChanges { get; }

        void EnsureDataSeeding();

        void SetInitialData(long newDbVersion);

        void UpdateData(long oldDbVersion, long newDbVersion);

        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        DbContextTransaction BeginTransaction(IsolationLevel isolation);

        Task<int> ExecuteSqlCommandAsync(string sql, params object[] args);

        Task<TEntity[]> SqlQueryArrayAsync<TEntity>(string sql, params object[] parameters);
    }
}