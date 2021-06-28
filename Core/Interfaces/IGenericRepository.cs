using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Spesifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
         Task<T> GetByIdAsync(int id);
         Task<IReadOnlyList<T>> ListAllAsync();
         Task<T> GetEntityWithSpec(ISpesification<T> spec);
         Task<IReadOnlyList<T>> ListAsync(ISpesification<T> spec); 
    }
}