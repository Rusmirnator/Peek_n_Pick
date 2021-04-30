using Microsoft.EntityFrameworkCore;
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

        public void Delete(int id, bool withRelated = false)
        {
            var deletedT = context.Set<T>().Find(id);

            context.Set<T>().Remove(deletedT);
        }

        public void DeleteMany(IEnumerable<T> deletedTs, bool withRelated = false)
        {
            context.RemoveRange(deletedTs);
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool withRelated = false)
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id, bool withRelated = false)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public void Update(T updatedT)
        {
            context.Entry(updatedT).State = EntityState.Modified;
        }

        public void UpdateMany(IEnumerable<T> updatedTs)
        {
            foreach(var entity in updatedTs)
            {
                context.Entry(entity).State = EntityState.Modified;
            }
        }
    }
}
