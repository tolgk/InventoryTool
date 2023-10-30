using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Application.Interfaces.Services;

namespace InventoryTool.Infrastructure.Services
{
    public class LoginService : ILoginService
    {

        private readonly ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var x = await _loginRepository.LoginAsync(email, password);
            return x;
        }
    }
}
