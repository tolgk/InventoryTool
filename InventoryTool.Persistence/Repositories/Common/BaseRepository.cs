using InventoryTool.Application.Interfaces;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Persistence.Repositories.Common
{
    public class BaseRepository<T> : IRepositories<T> where T : BaseEntity
    {
        private readonly InventoryToolDbContext _context;

        public BaseRepository(InventoryToolDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            var x = await Table.AddAsync(entity);
            return x.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public async Task<bool> DeleteById(int id)
        {
            T? entity = await Table.FirstOrDefaultAsync(e=> e.Id==id);
            if (entity != null)
            {
                var x = Table.Remove(entity);
                return x.State == EntityState.Deleted;
            }
            else { return false; }  
        }

        public async Task<List<T>> GetAllAsync() => await Table.ToListAsync();


        public async Task<T> GetById(int id) => await Table.FindAsync(id);


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);


        public bool Remove(T entity)
        {
            var x = Table.Remove(entity);
            return x.State == EntityState.Deleted;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public bool Update(T entity)
        {
            var x = Table.Update(entity);
            return x.State == EntityState.Modified;
        }
    }
}
