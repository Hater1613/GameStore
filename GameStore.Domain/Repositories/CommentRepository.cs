using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Repositories
{
    public class CommentRepository : AbstractRepository<Comment>
    {
        public CommentRepository(IDbContext context) : base(context) { }
    }
}
