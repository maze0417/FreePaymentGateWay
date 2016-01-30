using System.Data.Entity.ModelConfiguration;
using FreePayment.Core.Consts;
using FreePayment.Core.Interfaces;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Data.DbRepositories.TableMaps
{
    public class MerchantMap : EntityTypeConfiguration<Merchant>
    {
        public MerchantMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Merchants", config.TableSchema);

            HasKey(e => e.Id);

            Property(e => e.Name)
                .HasMaxLength(255)
                .IsRequired();

            Property(e => e.Description).HasMaxLength(255);

            Property(e => e.Status)
              .IsRequired();

            Property(e => e.Description)
                .HasColumnType(DbConst.Varchar)
                .HasMaxLength(255)
                .IsRequired();

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