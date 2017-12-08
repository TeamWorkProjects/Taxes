using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace taxes.services.Repository
{
    class Repository<T> : IRepository<T> where T : class
    {
        private DbContext _context;
        private DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(object id)
        {
            T entityToDelete = _dbSet.Find(id);
            if (entityToDelete!=null)
            {
                _context.Entry(entityToDelete).State = EntityState.Deleted;
                _context.SaveChanges();
            }

        }

        public T GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public T Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
    }
}
