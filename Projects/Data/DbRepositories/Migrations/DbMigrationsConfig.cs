using System.Data.Entity.Migrations;

namespace FreePayment.Data.DbRepositories.Migrations
{
    /// <summary>
    /// db migration : 
    /// add-migration Inital -ConfigurationTypeName FreePayment.Data.DbRepositories.Migrations.DbMigrationsConfig -ProjectName DbRepositories -StartupProjectName API  -ConnectionStringName Default
    /// update-database -TargetMigration:Inital -ConfigurationTypeName FreePayment.Data.DbRepositories.Migrations.DbMigrationsConfig -StartupProjectName API  -ConnectionStringName Default
    /// </summary>
    public class DbMigrationsConfig : DbMigrationsConfiguration<DbRepository>
    {
        //public const long DbVersion = 201512310716225;

        public DbMigrationsConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        //protected override void Seed(DbRepository db)
        //{
        //    var version = db.DbVersions.OrderByDescending(s => s.Version).Select(s => s.Version).FirstOrDefault();

        //    if (version == 0)
        //    {
        //        db.SetInitialData(DbVersion);
        //        db.SaveChanges();
        //    }
        //    if (version < DbVersion)
        //    {
        //        db.DbVersions.Add(new DbVersion
        //        {
        //            Version = DbVersion,
        //            Name = "Version-" + DbVersion,
        //            CreatedOn = DateTime.UtcNow
        //        });
        //        db.SaveChanges();
        //    }
        //    db.UpdateData(version, DbVersion);
        //    db.SaveChanges();
        //}
        //public void ForceSeed(DbRepository db) { Seed(db); }
    }
}