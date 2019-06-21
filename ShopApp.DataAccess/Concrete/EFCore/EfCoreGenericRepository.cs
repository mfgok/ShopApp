using Microsoft.EntityFrameworkCore;
using ShopApp.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EFCore
{
    public class EfCoreGenericRepository<T, TContext> : IRepository<T>
        where T:class
        where TContext:DbContext,new()
    {
        
        public void Create(T _entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Add(_entity);
                context.SaveChanges();
            }
        }

        public void Delete(T _entity)
        {
            using (var context = new TContext())
            {
                context.Set<T>().Remove(_entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter=null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<T>().ToList()
                    : context.Set<T>().Where(filter).ToList();
            }

        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        public T GetOne(Expression<Func<T, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Where(filter).SingleOrDefault();
            }
        }

        public void Update(T _entity)
        {
            using (var context = new TContext())
            {
                context.Entry(_entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
