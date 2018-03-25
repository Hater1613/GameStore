using GameStore.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace GameStore.Domain.EF.EntityConfigurations
{
    public class GenreEntityConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreEntityConfiguration()
        {
            Property(p => p.Name)
                .HasMaxLength(450)
                .HasColumnAnnotation("Index", new IndexAnnotation(new[] 
                {
                    new IndexAttribute("Index") { IsUnique = true }
                }));
            //HasOptional(g => g.ParentGenre)
            //    .WithMany(g => g.SubGenres)
            //    .HasForeignKey(g => g.ParentGenreId);
        }
    }
}