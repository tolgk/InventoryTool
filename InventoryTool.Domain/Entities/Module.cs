namespace InventoryTool.Domain.Entities
{
    public class Module : BaseEntity
    {
        public int AppId { get; set; }
        public string? Path { get; set; }
    }
}
