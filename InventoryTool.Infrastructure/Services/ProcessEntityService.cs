using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class ProcessEntityService :  IProcessEntityService
    {
        private readonly IRepositories<Process> _processRepo;

        public ProcessEntityService(IProcessEntityRepository processEntityRepository)
        {
            _processRepo = processEntityRepository;
        }

        public DbSet<Process> Table => _processRepo.Table;
        public async Task<bool> AddAsync(Process entity) => await _processRepo.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<Process> entities) => await _processRepo.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _processRepo.DeleteById(id);
        public async Task<List<Process>> GetAllAsync() => await _processRepo.GetAllAsync();
        public async Task<Process> GetById(int id) => await _processRepo.GetById(id);
        public async Task<Process> GetSingleAsync(Expression<Func<Process, bool>> method) => await _processRepo.GetSingleAsync(method);
        public bool Remove(Process entity) => _processRepo.Remove(entity);
        public async Task<int> SaveAsync() => await _processRepo.SaveAsync();
        public bool Update(Process entity) => _processRepo.Update(entity);
    }
}
