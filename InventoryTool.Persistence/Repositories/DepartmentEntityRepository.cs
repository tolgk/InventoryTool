using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Domain.Entities;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories.Common;


namespace InventoryTool.Persistence.Repositories
{
    public class DepartmentEntityRepository : BaseRepository<Department>, IDepartmentEntityRepository
    {
        public DepartmentEntityRepository(InventoryToolDbContext context) : base(context)
        {
        }
    }
}
