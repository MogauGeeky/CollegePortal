using System;
using System.Linq;
using System.Linq.Expressions;

namespace CollegePortal.Data
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}