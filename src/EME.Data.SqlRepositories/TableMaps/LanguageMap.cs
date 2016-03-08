using System.Data.Entity.ModelConfiguration;
using EME.Data.Models.DbEntities;
using EME.Infrastructure.Common.Configurations;
using EME.Infrastructure.Common.Consts;

namespace EME.Data.SqlRepositories.TableMaps
{
    public class LanguageMap : EntityTypeConfiguration<Language>
    {
        public LanguageMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Languages", config.TableSchema);
            HasKey(e => e.CultureCode);
            Property(e => e.CultureCode)
                .HasColumnType(DbConst.Varchar)
                .HasMaxLength(64);
            Property(e => e.LanguageCode)
                .HasColumnType(DbConst.Varchar)
                .HasMaxLength(64);
            Property(e => e.Name)
                .HasMaxLength(255);
            Property(e => e.LocalizedName)
                .HasMaxLength(255);
            Property(e => e.UpdatedOn)
                .IsRequired();
            Property(e => e.CreatedOn)
                .IsRequired();
            HasRequired(a => a.CreatedBy)
                .WithMany()
                .HasForeignKey(u => u.CreatedByUserId)
                .WillCascadeOnDelete(false);
            HasRequired(a => a.UpdatedBy)
                 .WithMany()
                 .HasForeignKey(u => u.UpdatedByUserId)
                 .WillCascadeOnDelete(false);
        }
    }
}