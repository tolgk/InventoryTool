using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class ModuleEntityService :  IModuleEntityService
    {
        private readonly IRepositories<Module> _moduleRepo;

        public ModuleEntityService(IModuleEntityRepository moduleEntityRepository)
        {
            _moduleRepo = moduleEntityRepository;
        }

        public DbSet<Module> Table => _moduleRepo.Table;
        public async Task<bool> AddAsync(Module entity) => await _moduleRepo.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<Module> entities) => await _moduleRepo.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _moduleRepo.DeleteById(id);
        public async Task<List<Module>> GetAllAsync() => await _moduleRepo.GetAllAsync();
        public async Task<Module> GetById(int id) => await _moduleRepo.GetById(id);
        public async Task<Module> GetSingleAsync(Expression<Func<Module, bool>> method) => await _moduleRepo.GetSingleAsync(method);
        public bool Remove(Module entity) => _moduleRepo.Remove(entity);
        public async Task<int> SaveAsync() => await _moduleRepo.SaveAsync();
        public bool Update(Module entity) => _moduleRepo.Update(entity);
    }
}
