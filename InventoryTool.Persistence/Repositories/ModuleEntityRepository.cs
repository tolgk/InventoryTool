using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;


namespace InventoryTool.Persistence.Repositories
{
    public class ModuleEntityRepository : BaseRepository<Module>, IModuleEntityRepository
    {
        public ModuleEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
