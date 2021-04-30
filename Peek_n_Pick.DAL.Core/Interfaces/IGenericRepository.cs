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
        Task<T> GetByIdAsync(int id, bool withRelated = false);
        Task<IEnumerable<T>> GetAllAsync(bool withRelated = false);
        void Update(T updatedT);
        void UpdateMany(IEnumerable<T> updatedTs);
        void Delete(int id, bool withRelated = false);
        void DeleteMany(IEnumerable<T> deletedTs, bool withRelated = false);
        Task<bool> CommitAsync();


    }
}
