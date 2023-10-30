using InventoryTool.Application.Exceptions;
using InventoryTool.Application.Interfaces.Repositories;
using InventoryTool.Persistence.Contexts;

namespace InventoryTool.Persistence.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly InventoryToolDbContext _context;

        public LoginRepository(InventoryToolDbContext context)
        {
            _context = context;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = _context.LOGIN_USER.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                throw new UserNotFoundException();
            }
            return true;
        }
    }
}
