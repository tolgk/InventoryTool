using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;


namespace InventoryTool.Persistence.Repositories
{
    public class PhazeEntityRepository : BaseRepository<Phaze>, IPhazeEntityRepository
    {
        public PhazeEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
