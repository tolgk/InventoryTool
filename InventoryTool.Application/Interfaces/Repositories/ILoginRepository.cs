namespace InventoryTool.Application.Interfaces.Repositories
{
    public interface ILoginRepository
    {
        Task<bool> LoginAsync(string email, string password);
    }
}
