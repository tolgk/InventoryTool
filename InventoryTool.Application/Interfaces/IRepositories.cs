using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Application.Interfaces
{
    public interface IRepositories<T> where T : BaseEntity
    {

        DbSet<T> Table { get; }
        Task<List<T>> GetAllAsync();
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetById(int id);

        bool Update(T entity);
        Task<bool> AddAsync(T entity);
        Task<bool> DeleteById(int id);
        bool Remove(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<int> SaveAsync();
    }
}
