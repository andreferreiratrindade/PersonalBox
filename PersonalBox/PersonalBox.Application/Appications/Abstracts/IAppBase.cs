using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBox.Application.Appications.Abstracts
{
   public interface IAppBase<TEntity> where TEntity : class
    {

        void Add(TEntity obj);
        TEntity GetById(int id);
        IQueryable<TEntity> All();
        void Update(TEntity obj);
        void Remove(TEntity obj);


    }
}
