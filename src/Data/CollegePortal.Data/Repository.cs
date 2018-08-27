using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CollegePortal.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext context;

        public Repository(DbContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            var dbEntityEntry = context.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                context.Set<T>().Add(entity);
            }

            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var dbEntityEntry = context.Entry(entity);

            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                context.Set<T>().Attach(entity);
                context.Set<T>().Remove(entity);
            }

            context.SaveChanges();
        }

        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includeProperties)
        {
            var query = context.Set<T>().AsQueryable();
            return includeProperties.Aggregate(query,
                (current, includeProperty) => current.Include(includeProperty)).AsNoTracking();
        }

        public void Update(T entity)
        {
            var dbEntityEntry = context.Entry(entity);

            if (dbEntityEntry.State == EntityState.Detached)
            {
                context.Set<T>().Attach(entity);
            }

            dbEntityEntry.State = EntityState.Modified;

            context.SaveChanges();
        }
    }
}