namespace InventoryTool.Application.Interfaces.Services
{
    public interface ILoginService
    {
        Task<bool> LoginAsync(string email, string password);
    }
}
