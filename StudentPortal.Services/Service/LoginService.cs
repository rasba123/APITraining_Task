using Microsoft.AspNetCore.Identity;
using StudentPortal.Services.IService;
using StudentPortal.Services.ViewModels;
using System.Threading.Tasks;

namespace StudentPortal.Services.Service
{
    public class LoginService : ILoginService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        //  private readonly UserManager<CustomIdentityUser> _userManager;

        public LoginService(SignInManager<IdentityUser> userManager)
        {
            _signInManager = userManager;
        }
        public async Task<bool> Login(LoginVM Input)
        {
            var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, Input.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public async Task<bool> LogoutAsync()
        {
            await _signInManager.SignOutAsync();

            return true;
        }
    }
}
