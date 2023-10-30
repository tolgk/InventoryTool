using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;

namespace InventoryTool.Persistence.Repositories
{
    public class ApplicationEntityRepository : BaseRepository<InventoryTool.Domain.Entities.Application>, IApplicationEntityRepository
    {
        public ApplicationEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
