using InventoryTool.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using InventoryTool.Web.Models;

namespace InventoryTool.Web.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly ILoginService _loginService;

        public LoginPageModel(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(LoginModel model)
        {
            var x = await _loginService.LoginAsync(model.Email, model.Password);
            if (x)
            {
                List<Claim> claims = new()
                {
                    new Claim(ClaimTypes.NameIdentifier, model.Email)
                };
                ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new(claimsIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToPage("Forms");
            }
            return Page();

        }
    }
}
