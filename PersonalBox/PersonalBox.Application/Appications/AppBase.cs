using PersonalBox.Application.Appications.Abstracts;
using PersonalBox.Domain.Interfaces.AppServices;
using PersonalBox.Domain.Interfaces.Repositories;
using System.Linq;

namespace PersonalBox.Application.Appications
{
    public class AppBase<TEntity> : IAppBase<TEntity> where TEntity : class
    {
        protected  IAppService<TEntity> _appService;

        public AppBase(IAppService<TEntity> appService)
        {
            _appService = appService;
        }

        public void Add(TEntity obj)
        {
            _appService.Add(obj);
        }

        public IQueryable<TEntity> All()
        {
            return _appService.All();
        }

        public TEntity GetById(int id)
        {
            return _appService.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _appService.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _appService.Update(obj);
        }
    }
}
