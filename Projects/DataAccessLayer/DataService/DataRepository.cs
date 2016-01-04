using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using FP.Core.Interfaces.Context;
using FP.Core.Interfaces.DataService;
using FP.Core.Models;

namespace FP.DataAccessLayer.DataService
{
    public class DataRepository : DbContext , IDataRepository
    {
        private readonly IDataConfig _dataConfig;
        private const string Varchar = "VARCHAR";
        private const string Varbinary = "VARBINARY";

        public DataRepository(IDataConfig dataConfig) 
            : base("name=" + dataConfig.KeyForConnectionString)
        {
            _dataConfig = dataConfig;
        }
        #region table

        public IDbSet<Merchant> Merchants { get; set; }

        #endregion

        bool IDataRepository.HasChanges => ChangeTracker.HasChanges();

        Action<string> IDataRepository.Log
        {
            get { return Database.Log; }
            set { Database.Log = value; }
        }
        
        DbContextTransaction IDataRepository.BeginTransaction(IsolationLevel isolation)
        {
            return Database.BeginTransaction(isolation);
        }

        void IDataRepository.EnsureDataSeeding()
        {
            throw new NotImplementedException();
        }

        Task<int> IDataRepository.ExecuteSqlCommandAsync(string sql, params object[] args)
        {
            return Database.ExecuteSqlCommandAsync(sql, args);
        }
        
        void IDataRepository.SetInitialData(long newDbVersion)
        {
            throw new NotImplementedException();
        }

        Task<TEntity[]> IDataRepository.SqlQueryArrayAsync<TEntity>(string sql, params object[] parameters)
        {
            return Database.SqlQuery<TEntity>(sql, parameters).ToArrayAsync();
        }

        void IDataRepository.UpdateData(long oldDbVersion, long newDbVersion)
        {
            throw new NotImplementedException();
        }
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            ValidateDataConfig();

            mb.Configurations.Add(new LicenseeMap(_dataConfig));
       
        }
    }
}