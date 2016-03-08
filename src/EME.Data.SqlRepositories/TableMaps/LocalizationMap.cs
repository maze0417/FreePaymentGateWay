using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using EME.Data.Models.DbEntities;
using EME.Infrastructure.Common.Configurations;

namespace EME.Data.SqlRepositories.TableMaps
{
    public class LocalizationMap : EntityTypeConfiguration<Localization>
    {
        public LocalizationMap(IDataConfig config)
        {
            ToTable(config.TablePrefix + "Localization", config.TableSchema);
            HasKey(e => e.Id);
            Property(e => e.Code)
                .HasMaxLength(200)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute(config.TablePrefix + "UX_Localization_Code_Context_CultureCode", 1) { IsUnique = true }));
            Property(e => e.Context)
                .HasMaxLength(200)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute(config.TablePrefix + "UX_Localization_Code_Context_CultureCode", 2) { IsUnique = true }));
            Property(e => e.CultureCode)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute(config.TablePrefix + "UX_Localization_Code_Context_CultureCode", 3) { IsUnique = true }));
            Property(e => e.Description)
                .HasMaxLength(255);
        }
    }
}