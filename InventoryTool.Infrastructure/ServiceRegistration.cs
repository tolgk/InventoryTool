using InventoryTool.Application.Interfaces.Services;
using InventoryTool.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;


namespace InventoryTool.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationEntityService,ApplicationEntityService>();
            services.AddScoped<IProcessEntityService,ProcessEntityService>();
            services.AddScoped<IDepartmentEntityService,DepartmentEntityService>();
            services.AddScoped<IPhazeEntityService,PhazeEntityService>();
            services.AddScoped<IModuleEntityService,ModuleEntityService>();
            services.AddScoped<ISubProcessEntityService,SubProcessEntityService>();
            services.AddScoped<ILoginService,LoginService>();
        }
    }
}
