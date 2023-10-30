using InventoryTool.Application.Interfaces;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace InventoryTool.Infrastructure.Services
{
    public class ApplicationEntityService : IApplicationEntityService 
    {
        private readonly IRepositories<Domain.Entities.Application> _appRepository;

        public ApplicationEntityService(IApplicationEntityRepository applicationEntityRepository)
        {
            _appRepository = applicationEntityRepository;
        }

        public DbSet<Domain.Entities.Application> Table => _appRepository.Table;
        public async Task<bool> AddAsync(Domain.Entities.Application entity) => await _appRepository.AddAsync(entity);
        public async Task<bool> AddRangeAsync(List<Domain.Entities.Application> entities) => await _appRepository.AddRangeAsync(entities);
        public async Task<bool> DeleteById(int id) => await _appRepository.DeleteById(id);
        public async Task<List<Domain.Entities.Application>> GetAllAsync() => await _appRepository.GetAllAsync();
        public async Task<Domain.Entities.Application> GetById(int id) => await _appRepository.GetById(id);
        public async Task<Domain.Entities.Application> GetSingleAsync(Expression<Func<Domain.Entities.Application, bool>> method) => await _appRepository.GetSingleAsync(method);
        public bool Remove(Domain.Entities.Application entity) => _appRepository.Remove(entity);
        public async Task<int> SaveAsync() => await _appRepository.SaveAsync();
        public bool Update(Domain.Entities.Application entity) => _appRepository.Update(entity);

    }
}
