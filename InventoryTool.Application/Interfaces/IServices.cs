using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Application.Interfaces
{
    public interface IServices<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> DeleteById(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        bool Remove(T entity);
        bool Update(T entity);
        Task<int> SaveAsync();
    }
}
