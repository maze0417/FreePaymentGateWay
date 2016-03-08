using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using EME.Data.Models.DbEntities;
using EME.Infrastructure.Common.Configurations;

namespace EME.Data.SqlRepositories.TableMaps
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