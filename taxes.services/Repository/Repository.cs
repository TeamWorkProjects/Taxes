using System;
using Microsoft.EntityFrameworkCore;
using taxes.services.Context;

namespace taxes.services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ApplicationDbContext context;
        private DbSet<T> dbSet;

        public Repository(ApplicationDbContext context)
        {
            this.context = context;
            dbSet = this.context.Set<T>();
        }

        public T Create(T entity)
        {
            dbSet.Add(entity);
            Save();
            return entity;
        }

        public void Delete(object id)
        {
            T entityToDelete = dbSet.Find(id);
            if (entityToDelete!=null)
            {
                context.Entry(entityToDelete).State = EntityState.Deleted;
                Save();
            }

        }

        public T GetById(object id)
        {
            return dbSet.Find(id);
        }

        public T Update(T entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            Save();
            return entity;
        }

        private void Save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }
    }
}
