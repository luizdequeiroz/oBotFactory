using domain.Attributes.FieldControls;
using domain.Entities;
using repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Objects;
using System.Reflection;
using System.Threading.Tasks;

namespace service.Implementations
{
    internal class GenericService<E> : IGenericService<E> where E : Entity
    {
        protected readonly IGenericRepository<E> genericRepository;

        public GenericService(IGenericRepository<E> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public virtual async Task<E> SetNewAsync(E entity)
        {
            return await genericRepository.InsertAsync(entity);
        }

        public virtual async Task<IList<E>> GetAllAsync()
        {
            var all = await genericRepository.SelectAllAsync();
            return all.ToList();
        }

        public virtual async Task<E> GetByIdAsync(int id)
        {
            return await genericRepository.SelectByIdAsync(id);
        }

        public virtual async Task<E> AlterAsync(int id, E entity)
        {
            entity.Id = id;
            var original = await GetByIdAsync(entity.Id);
            var exceptions = new List<string>();
            entity.GetType().GetProperties().ToList().ForEach(prop =>
            {
                if (prop.GetCustomAttributes(typeof(NotSetAutomatically), true).Length > 0)
                {
                    exceptions.Add(prop.Name);
                }

                var value = prop.GetValue(entity);
                bool isUnsetted = false;

                switch (prop.PropertyType.Name)
                {
                    case "String":
                        isUnsetted = string.IsNullOrEmpty(value?.ToString());
                        break;
                    case "Int32":
                        isUnsetted = Convert.ToInt32(value) == default(int);
                        break;
                    case "Double":
                        isUnsetted = Convert.ToDouble(value) == default(double);
                        break;
                    case "DateTime":
                        isUnsetted = Convert.ToDateTime(value) == default(DateTime);
                        break;
                    default: break;
                }

                if (isUnsetted) exceptions.Add(prop.Name);
            });

            original.SetProperties(entity, exceptions.ToArray());
            original.UpdateDate = DateTime.Now;
            return await genericRepository.UpdateAsync(original);
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            E result = await GetByIdAsync(id);
            if (result == null) return false;
            await genericRepository.DeleteAsync(result);

            return true;
        }
    }
}
