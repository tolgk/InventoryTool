using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class PhazeEntityService :  IPhazeEntityService
    {
        private readonly IRepositories<Phaze> _phazeRepo;

        public PhazeEntityService(IPhazeEntityRepository phazeEntityRepository)
        {
            _phazeRepo = phazeEntityRepository;
        }

        public DbSet<Phaze> Table => _phazeRepo.Table;
        public async Task<bool> AddAsync(Phaze entity) => await _phazeRepo.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<Phaze> entities) => await _phazeRepo.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _phazeRepo.DeleteById(id);
        public async Task<List<Phaze>> GetAllAsync() => await _phazeRepo.GetAllAsync();
        public async Task<Phaze> GetById(int id) => await _phazeRepo.GetById(id);
        public async Task<Phaze> GetSingleAsync(Expression<Func<Phaze, bool>> method) => await _phazeRepo.GetSingleAsync(method);
        public bool Remove(Phaze entity) => _phazeRepo.Remove(entity);
        public async Task<int> SaveAsync() => await _phazeRepo.SaveAsync();
        public bool Update(Phaze entity) => _phazeRepo.Update(entity);
    }
}
