using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Linq.Expressions;
using LinqKit;

namespace RepositoryPattern.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public IObjectSet<T> ObjectSet;

        public BaseRepository(IUnitOfWork unitOfWork)
        {
            ObjectSet = unitOfWork.CreateObjectSet<T>();
        }

        public void Add(T item)
        {
            ObjectSet.AddObject(item);
        }

        public void Delete(T item)
        {
            ObjectSet.DeleteObject(item);
        }

        public T GetSingle(Expression<Func<T, bool>> criteria)
        {
            return ObjectSet.Where(criteria).FirstOrDefault();
        }

        public T GetSingle(Expression<Func<T, bool>> criteria, string[] includes)
        {
            ObjectQuery<T> query = (ObjectSet<T>)ObjectSet;

            foreach (string include in includes)
                query = query.Include(include);

            return query.FirstOrDefault(criteria);
        }

        public IEnumerable<T> GetMultiple(Expression<Func<T, bool>> criteria)
        {
            return ObjectSet.AsExpandable().Where(criteria);
        }

        public IEnumerable<T> GetMultiple(Expression<Func<T, bool>> criteria, string[] includes)
        {
            ObjectQuery<T> query = (ObjectSet<T>)ObjectSet;

            foreach (string include in includes)
                query = query.Include(include);

            return query.Where(criteria);
        }

        public IEnumerable<T> GetAll()
        {
            return ObjectSet;
        }

        public int Count(Expression<Func<T, bool>> criteria)
        {
            return ObjectSet.AsExpandable().Count(criteria);
        }

        public int Count()
        {
            return ObjectSet.AsExpandable().Count();
        }
    }
}
