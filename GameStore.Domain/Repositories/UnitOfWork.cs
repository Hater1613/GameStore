using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;

namespace GameStore.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContext context;
        private IRepository<Game> gameRepository;
        private IRepository<Comment> commentRepository;
        private IRepository<Genre> genreRepository;
        private IRepository<PlatformType> platformTypeRepository;

        public UnitOfWork(IDbContext context)
        {
            this.context = context;
        }

        public IRepository<Game> Games
        {
            get
            {
                if (gameRepository == null)
                    gameRepository = new GameRepository(context);
                return gameRepository;
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                if (commentRepository == null)
                    commentRepository = new CommentRepository(context);
                return commentRepository;
            }
        }

        public IRepository<Genre> Genres
        {
            get
            {
                if (genreRepository == null)
                    genreRepository = new GenreRepository(context);
                return genreRepository;
            }
        }

        public IRepository<PlatformType> PlatformTypes
        {
            get
            {
                if (platformTypeRepository == null)
                    platformTypeRepository = new PlatformTypeRepository(context);
                return platformTypeRepository;
            }
        }

        public void Commit()
        {
            if (context != null)
                context.SaveChanges();
        }
    }
}