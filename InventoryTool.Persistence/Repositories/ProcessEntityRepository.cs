using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;



namespace InventoryTool.Persistence.Repositories
{
    public class ProcessEntityRepository : BaseRepository<Process>, IProcessEntityRepository
    {
        public ProcessEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
