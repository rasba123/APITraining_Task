using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudentPortal.Services.IService;
using StudentPortal.Services.ViewModels;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Services.Service
{
    public class LoginService : ILoginService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public LoginService(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;
        }
        public async Task<object> Login(LoginVM Input)
        {
            var result = await _signInManager.PasswordSignInAsync(Input.Username, Input.Password, Input.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                return result;
            }
            else
            {

                return result;
            }
        }
        public async Task<bool> LogoutAsync()
        {
            await _signInManager.SignOutAsync();

            return true;
        }

        public async Task<string> CreateToken(LoginVM loginModel)
        {

            var loginResult = await _signInManager.PasswordSignInAsync(loginModel.Username, loginModel.Password, isPersistent: false, lockoutOnFailure: false);

            if (!loginResult.Succeeded)
            {
                return "Bad Request";
            }

            var user = await _userManager.FindByNameAsync(loginModel.Username);

            return GetToken(user);
        }

        private string GetToken(IdentityUser user)
        {
            var utcNow = DateTime.UtcNow;

            var claims = new Claim[]
            {
                        new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, utcNow.ToString())
            };

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Secret"]));
            var signingCredentials = new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256);
          var jwt =  new JwtSecurityToken(
    expires: utcNow.AddDays(10),
    claims: claims,
     signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
     );

            return new JwtSecurityTokenHandler().WriteToken(jwt);

        }
    }
}
