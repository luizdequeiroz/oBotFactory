using domain;
using domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Objects;
using System.Threading.Tasks;

namespace repository.Implementations
{
    internal class GenericRepository<E> : IGenericRepository<E> where E : Entity
    {
        private readonly OBotFactoryContext context;

        public GenericRepository(OBotFactoryContext context)
        {
            this.context = context;
        }

        public async Task<E> InsertAsync(E entity)
        {
            await context.Set<E>().AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<IQueryable<E>> SelectAllAsync()
        {
            return await Task.FromResult(context.Set<E>());
        }

        public async Task<E> SelectByIdAsync(int id)
        {
            return await context.Set<E>().FindAsync(id);
        }

        public async Task<IQueryable<E>> SelectWhereAsync(Expression<Func<E, bool>> expression)
        {
            return await Task.FromResult(context.Set<E>().Where(expression));
        }

        public async Task<E> UpdateAsync(E entity)
        {
            E result = await context.Set<E>().FindAsync(entity.Id);
            result.SetProperties(entity);

            await context.SaveChangesAsync();
            return result;
        }

        public async Task DeleteAsync(E entity)
        {
            await Task.Run(() => context.Set<E>().Remove(entity));
            await context.SaveChangesAsync();
        }
    }
}
