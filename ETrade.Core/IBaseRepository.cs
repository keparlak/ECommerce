using Microsoft.EntityFrameworkCore;

namespace ETrade.Core
{
    public interface IBaseRepository<T> where T : class
    {
        public List<T> List();

        public T Find(Guid Id);

        public bool Update(T entity);

        public bool Delete(T entity);

        public bool Add(T entity);

        DbSet<T> Set();
    }
}