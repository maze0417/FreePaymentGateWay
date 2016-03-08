using System.Data.Entity.ModelConfiguration;
using EME.Data.Models.DbEntities;
using EME.Infrastructure.Common.Configurations;
using EME.Infrastructure.Common.Consts;

namespace EME.Data.SqlRepositories.TableMaps
{
    public class PaymentMap : EntityTypeConfiguration<Payment>
    {
        public PaymentMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Payments", config.TableSchema);

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