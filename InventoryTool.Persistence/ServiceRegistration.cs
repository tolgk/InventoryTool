using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Persistence.Contexts;
using InventoryTool.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryTool.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services )
        {
            ConfigurationManager configurationManager = new();
            configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../InventoryTool.Web"));
            configurationManager.AddJsonFile("appsettings.json");

            services.AddDbContext<InventoryToolDbContext>
                (opt => opt.UseSqlServer(configurationManager.GetConnectionString("DefaultConnection")));

            services.AddScoped<IApplicationEntityRepository,ApplicationEntityRepository>();
            services.AddScoped<IPhazeEntityRepository,PhazeEntityRepository>();
            services.AddScoped<IProcessEntityRepository,ProcessEntityRepository>();
            services.AddScoped<ISubProcessEntityRepository,SubProcessEntityRepository>();
            services.AddScoped<IDepartmentEntityRepository,DepartmentEntityRepository>();
            services.AddScoped<IModuleEntityRepository,ModuleEntityRepository>();
            services.AddScoped<ILoginRepository,LoginRepository>();

            

        }
    }
}
