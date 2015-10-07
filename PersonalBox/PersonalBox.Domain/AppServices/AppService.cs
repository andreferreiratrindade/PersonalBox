using PersonalBox.Domain.Interfaces.AppServices;
using PersonalBox.Domain.Interfaces.Repositories;
using System.Linq;

namespace PersonalBox.Domain.AppServices
{
    public class AppService<TEntity> : IAppService<TEntity> where TEntity : class
    {
        private IRepository<TEntity> _repository;

        public AppService(IRepository<TEntity> repository)
        {
            _repository = repository;
            
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public IQueryable<TEntity> All()
        {
           return _repository.All();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }
    }
}
