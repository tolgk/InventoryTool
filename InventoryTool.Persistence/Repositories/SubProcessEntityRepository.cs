using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;


namespace InventoryTool.Persistence.Repositories
{
    public class SubProcessEntityRepository : BaseRepository<SubProcess>, ISubProcessEntityRepository
    {
        public SubProcessEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
