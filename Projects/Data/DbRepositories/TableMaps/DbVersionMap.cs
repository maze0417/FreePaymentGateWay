using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using FreePayment.Core.Interfaces;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Data.DbRepositories.TableMaps
{
    public class DbVersionMap : EntityTypeConfiguration<DbVersion>
    {
        public DbVersionMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Schemas", config.TableSchema);
            HasKey(e => e.Version);
            Property(e => e.Version)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(e => e.Name)
                .HasMaxLength(255);
        }
    }
}