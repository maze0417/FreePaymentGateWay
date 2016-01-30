using System.Data.Entity.ModelConfiguration;
using FreePayment.Core.Consts;
using FreePayment.Core.Interfaces;
using FreePayment.Data.Models.DbEntities;

namespace FreePayment.Data.DbRepositories.TableMaps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Users", config.TableSchema);
            HasKey(e => e.Id);

            Property(e => e.Username)
                .HasColumnType(DbConst.Varchar)
                .HasMaxLength(32)
                .IsRequired();

            Property(e => e.Firstname)
                .HasMaxLength(32)
                .IsRequired();

            Property(e => e.Lastname)
                .HasMaxLength(32)
                .IsRequired();

            Property(e => e.Password)
                .HasColumnType(DbConst.Varbinary)
                .HasMaxLength(128)
                .IsRequired();

            Property(e => e.Salt)
                .HasColumnType(DbConst.Varbinary)
                .HasMaxLength(128)
                .IsRequired();

            Property(e => e.Email)
                .HasColumnType(DbConst.Varchar)
                .HasMaxLength(255)
                .IsRequired();

            Property(e => e.CreatedOn)
               .IsRequired();

            Property(e => e.UpdatedOn)
               .IsRequired();

            HasRequired(p => p.CreatedBy)
                .WithMany()
                .HasForeignKey(s => s.CreatedByUserId);

            Property(e => e.CreatedByUserId)
                .IsRequired();

            HasRequired(p => p.UpdatedBy)
               .WithMany()
               .HasForeignKey(s => s.UpdatedByUserId);

            Property(e => e.UpdatedByUserId)
               .IsRequired();
        }
    }
}