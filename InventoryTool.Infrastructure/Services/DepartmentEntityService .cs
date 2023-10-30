using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class DepartmentEntityService : IDepartmentEntityService
    {
        private readonly IRepositories<Department> _departmentRepo;

        public DepartmentEntityService(IDepartmentEntityRepository departmentEntityRepository)
        {
            _departmentRepo = departmentEntityRepository;
        }

        public DbSet<Department> Table => _departmentRepo.Table;
        public async Task<bool> AddAsync(Department entity) => await _departmentRepo.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<Department> entities) => await _departmentRepo.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _departmentRepo .DeleteById(id);
        public async Task<List<Department   >> GetAllAsync() => await _departmentRepo.GetAllAsync();
        public async Task<Department> GetById(int id) => await _departmentRepo.GetById(id);
        public async Task<Department> GetSingleAsync(Expression<Func<Department, bool>> method) => await _departmentRepo.GetSingleAsync(method);
        public bool Remove(Department entity) => _departmentRepo.Remove(entity);
        public async Task<int> SaveAsync() => await _departmentRepo.SaveAsync();
        public bool Update(Department entity) => _departmentRepo.Update(entity);
    }
}
