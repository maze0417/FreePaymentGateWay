using System.Data.Entity.ModelConfiguration;
using FP.Core.Interfaces.Context;
using FP.Core.Models;

namespace FP.DataAccessLayer.DataService.TableMap
{
    public class MerchantMap : EntityTypeConfiguration<Merchant>
    {
        public MerchantMap()
        { 
                ToTable(nameof(Merchant));

                HasKey(e => e.Id);

                Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsRequired();

                Property(e => e.Description).HasMaxLength(255);
             
                Property(e => e.Status)
                  .IsRequired();

                Property(e => e.Description)
                    .HasColumnType(Varchar)
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