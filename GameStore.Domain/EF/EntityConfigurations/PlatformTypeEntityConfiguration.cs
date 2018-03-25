using GameStore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace GameStore.Domain.EF.EntityConfigurations
{
    public class PlatformTypeEntityConfiguration : EntityTypeConfiguration<PlatformType>
    {
        public PlatformTypeEntityConfiguration()
        {
            Property(p => p.Type)
               .HasMaxLength(450)
               .HasColumnAnnotation("Index", new IndexAnnotation(new[]
               {
                    new IndexAttribute("Index") { IsUnique = true }
               }));
        }
    }
}