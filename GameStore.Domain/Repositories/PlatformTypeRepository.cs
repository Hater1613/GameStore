using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Repositories
{
    public class PlatformTypeRepository : AbstractRepository<PlatformType>
    {
        public PlatformTypeRepository(IDbContext context) : base(context) { }
    }
}