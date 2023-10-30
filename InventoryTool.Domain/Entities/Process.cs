namespace InventoryTool.Domain.Entities
{
    public class Process : BaseEntity
    {
        public int Code { get; set; }
        public int DepartmentId { get; set; }
        public int ExecTime {  get; set; }
        public int PhazeId { get; set; }
        public List<Process>? Processes { get; set; }
    }
}
