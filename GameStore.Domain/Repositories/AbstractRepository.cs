using GameStore.Domain.Abstract;
using GameStore.Domain.EF;
using System.Data.Entity;
using System.Linq;

namespace GameStore.Domain.Repositories
{
    public class AbstractRepository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext db;

        public AbstractRepository(IDbContext context)
        {
            db = context;
        }

        public void Add(T item)
        {
            db.Set<T>().Add(item);
        }

        public T GetItem(int id)
        {
            return db.Set<T>().Find(id);
        }

        public IQueryable<T> GetList()
        {
            return db.Set<T>();
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(T item)
        {
            db.Set<T>().Remove(item);
        }
    }
}