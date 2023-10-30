using InventoryTool.Domain.Entities;

namespace InventoryTool.Web.Models
{

    public class AppModel
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }
        
        public string? Description { get; set; }
        
        public int? SubModuleId { get; set; }
        
        public string? ModuleName { get; set; }
        
        public string? SubModulePath { get; set; }
        
        public string? ModuleDescription { get; set; }

        public List<Domain.Entities.Application>? Applications;

        public List<Module>? Modules { get; set; }
    }
}
