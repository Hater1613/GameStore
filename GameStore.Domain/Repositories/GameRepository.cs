using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Domain.Repositories
{
    public class GameRepository : AbstractRepository<Game>
    {
        public GameRepository(IDbContext context) : base(context) { }
    }
}
