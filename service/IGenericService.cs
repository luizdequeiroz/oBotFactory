using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace service
{
    public interface IGenericService<E>
    {
        Task<E> SetNewAsync(E entity);
        Task<IList<E>> GetAllAsync();
        Task<E> GetByIdAsync(int id);
        Task<E> AlterAsync(int id, E entity);
        Task<bool> DeleteAsync(int id);
    }
}
