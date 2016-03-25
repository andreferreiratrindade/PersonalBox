
using System.Linq;

namespace PersonalBox.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        TEntity GetById(string id);
        IQueryable<TEntity> All();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        bool Remove(int id);
    }
}
