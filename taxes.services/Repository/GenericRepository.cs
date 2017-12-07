using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using taxes.services.Context;

namespace taxes.services.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<TEntity> Create(TEntity entity)
        {
            if(entity != null)
            {
                await context.Set<TEntity>().AddAsync(entity);
                return entity;
            }
            else
            {
                throw new Exception();
            }
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);

            await context.SaveChangesAsync();
            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
           context.Set<TEntity>().Update(entity);
           await context.SaveChangesAsync();
           return entity;
        }
    }
}