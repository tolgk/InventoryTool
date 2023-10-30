namespace InventoryTool.Domain.Entities
{
    public class Application : BaseEntity
    {
        public List<Module>? Modules { get; set; }
    }
}
