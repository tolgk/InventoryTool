using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class SubProcessEntityService :  ISubProcessEntityService
    {
        private readonly IRepositories<SubProcess> _subProcessRepo;

        public SubProcessEntityService(ISubProcessEntityRepository subProcessEntityRepository)
        {
            _subProcessRepo = subProcessEntityRepository;
        }

        public DbSet<SubProcess> Table => _subProcessRepo.Table;
        public async Task<bool> AddAsync(SubProcess entity) => await _subProcessRepo.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<SubProcess> entities) => await _subProcessRepo.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _subProcessRepo.DeleteById(id);
        public async Task<List<SubProcess>> GetAllAsync() => await _subProcessRepo.GetAllAsync();
        public async Task<SubProcess> GetById(int id) => await _subProcessRepo.GetById(id);
        public async Task<SubProcess> GetSingleAsync(Expression<Func<SubProcess, bool>> method) => await _subProcessRepo.GetSingleAsync(method);
        public bool Remove(SubProcess entity) => _subProcessRepo.Remove(entity);
        public async Task<int> SaveAsync() => await _subProcessRepo.SaveAsync();
        public bool Update(SubProcess entity) => _subProcessRepo.Update(entity);
    }
}
