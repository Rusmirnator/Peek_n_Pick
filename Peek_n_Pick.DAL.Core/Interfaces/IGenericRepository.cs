using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.DAL.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T newT);
        Task AddManyAsync(IEnumerable<T> newTs);
        Task GetByIdAsync(int id, bool withRelated = false);
        Task GetAllAsync(bool withRelated = false);
        Task UpdateAsync(T updatedT);
        Task UpdateManyAsync(IEnumerable<T> updatedTs);
        Task DeleteAsync(int id, bool withRelated = false);
        Task DeleteManyAsync(IEnumerable<T> deletedTs, bool withRelated = false);
        Task<bool> CommitAsync();


    }
}
