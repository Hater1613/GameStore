using GameStore.Domain.Entities;

namespace GameStore.Domain.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<Game> Games { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Genre> Genres { get; }
        IRepository<PlatformType> PlatformTypes { get; }
        void Commit();
    }
}