using GameStore.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GameStore.Domain.Abstract
{
    public interface IDbContext
    {
        DbSet<Game> Games { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Genre> Genres { get; set; }
        DbSet<PlatformType> PlatformTypes { get; set; }
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry<T> Entry<T>(T entity) where T : class;
        Database Database { get; }
        int SaveChanges();
        void Dispose();
    }
}