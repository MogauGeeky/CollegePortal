using System.Data.Entity;
using System.Linq;

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

        public IQueryable<T> GetAll()
        {
            return context.Set<T>().AsNoTracking();
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