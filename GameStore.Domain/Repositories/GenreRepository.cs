using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Repositories
{
    public class GenreRepository : AbstractRepository<Genre>
    {
        public GenreRepository(IDbContext context) : base(context) { }
    }
}
