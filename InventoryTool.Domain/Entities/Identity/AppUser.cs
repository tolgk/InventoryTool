using Microsoft.AspNetCore.Identity;

namespace InventoryTool.Domain.Entities.Identity
{
    public class AppUser 
    {
        public int Id { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
