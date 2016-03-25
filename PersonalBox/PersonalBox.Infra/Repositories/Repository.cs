using PersonalBox.Domain.Interfaces.Repositories;
using PersonalBox.Infra.Context;
using System;
using System.Linq;

namespace PersonalBox.Infra.Repositories
{
    public class Repository<TEntity> :IDisposable, IRepository<TEntity> where TEntity : class
    {
        protected PersonalBoxContext Db = new PersonalBoxContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public IQueryable<TEntity> All()
        {
            return Db.Set<TEntity>().AsQueryable();
        }

        public TEntity GetById(string id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
            
        }

        public void Dispose()
        {
            Db.Dispose();
        }

        public bool Remove(int id)
        {
            TEntity obj = Db.Set<TEntity>().Find(id);
            if (obj != null)
            {
                Db.Set<TEntity>().Remove(Db.Set<TEntity>().Find(id));
                Db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
