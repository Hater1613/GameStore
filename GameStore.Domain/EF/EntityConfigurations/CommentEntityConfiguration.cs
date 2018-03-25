using GameStore.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GameStore.Domain.EF.EntityConfigurations
{
    public class CommentEntityConfiguration : EntityTypeConfiguration<Comment>
    {
        public CommentEntityConfiguration()
        {
            //HasOptional(c => c.ParentComment)
            //    .WithMany(c => c.SubComments)
            //    .HasForeignKey(c => c.ParentCommentId);
        }
    }
}