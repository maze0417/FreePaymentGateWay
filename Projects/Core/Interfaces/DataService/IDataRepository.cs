using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using FP.Core.Models;

namespace FP.Core.Interfaces.DataService
{
    public interface IDataRepository
    {
        IDbSet<Merchant> Merchants { get; set; }

        void EnsureDataSeeding();

        void SetInitialData(long newDbVersion);

        void UpdateData(long oldDbVersion, long newDbVersion);
        Action<string> Log { get; set; }
        
        bool HasChanges { get; }

        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        DbContextTransaction BeginTransaction(IsolationLevel isolation);

        Task<int> ExecuteSqlCommandAsync(string sql, params object[] args);

        Task<TEntity[]> SqlQueryArrayAsync<TEntity>(string sql, params object[] parameters);
    }
}