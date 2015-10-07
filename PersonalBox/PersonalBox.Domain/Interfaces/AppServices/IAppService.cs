using System.Linq;

namespace PersonalBox.Domain.Interfaces.AppServices
{
    public interface IAppService<TEntity> where TEntity  : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IQueryable<TEntity> All();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
