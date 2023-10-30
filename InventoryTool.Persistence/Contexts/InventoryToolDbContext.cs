using InventoryTool.Domain.Entities;
using InventoryTool.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace InventoryTool.Persistence.Contexts
{
    public  class InventoryToolDbContext : DbContext
    {
        public InventoryToolDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Domain.Entities.Application> Frm_Env_Application { get; set; }
        public DbSet<Department> FRM_ENV_DEPARTMENT { get; set; }
        public DbSet<Module> FRM_SUB_ENV_MODULE { get; set; }
        public DbSet<Phaze> FRM_ENV_PHAZE { get; set; }
        public DbSet<Process> FRM_ENV_PARENT_PROCESS { get; set; }
        public DbSet<SubProcess> FRM_ENV_SUB_PROCESS { get; set; }
        public DbSet<AppUser> LOGIN_USER { get; set; }

    }
}
