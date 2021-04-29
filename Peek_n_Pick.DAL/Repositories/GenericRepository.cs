using Peek_n_Pick.DAL.Core.Interfaces;
using Peek_n_Pick.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peek_n_Pick.DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext context;

        public GenericRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(T newT)
        {
            await context.Set<T>().AddAsync(newT);
        }

        public async Task AddManyAsync(IEnumerable<T> newTs)
        {
            await context.Set<T>().AddRangeAsync(newTs);
        }

        public async Task<bool> CommitAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public Task DeleteAsync(int id, bool withRelated = false)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(IEnumerable<T> deletedTs, bool withRelated = false)
        {
            throw new NotImplementedException();
        }

        public Task GetAllAsync(bool withRelated = false)
        {
            throw new NotImplementedException();
        }

        public Task GetByIdAsync(int id, bool withRelated = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T updatedT)
        {
            throw new NotImplementedException();
        }

        public Task UpdateManyAsync(IEnumerable<T> updatedTs)
        {
            throw new NotImplementedException();
        }
    }
}
