using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using System.Data.Entity;

namespace GameStore.Domain.EF
{
    public class GameStoreContext : DbContext, IDbContext
    {
        public GameStoreContext(string connection) : base(connection) { }

        static GameStoreContext()
        {
            Database.SetInitializer<GameStoreContext>(new GameStoreDbInitializer());
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<PlatformType> PlatformTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}