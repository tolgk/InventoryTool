namespace InventoryTool.Domain.Entities
{
    public class SubProcess : BaseEntity
    {
        public int Code { get; set; }
        public int ParentProcessId { get; set; }
        public string? ActiveProcessName { get; set; }
        public List<Module>? Modules { get; set; }
    }
}
