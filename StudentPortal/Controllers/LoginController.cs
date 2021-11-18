using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StudentPortal.Services.IService;
using StudentPortal.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentPortal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private ILoginService LoginService;
        private readonly ILogger<LoginController> _logger;
        public LoginController(ILogger<LoginController> logger, ILoginService loginService)
        {
            _logger = logger;
            this.LoginService = loginService;
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginVM User)
        {
            string SuccessVal = "";
            object Success = await LoginService.Login(User);

            return Ok(Success);

        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            string SuccessVal = "";
            bool Success = await LoginService.LogoutAsync();
            if (Success == true)
            {
                SuccessVal = "Logout";
            }
            else
            {
                SuccessVal = "user not logout";
            }
            return Ok(SuccessVal);
        }

        [HttpPost("token")]
        public async Task<IActionResult> CreateToken([FromBody] LoginVM loginModel)
        {
            string Success = await LoginService.CreateToken(loginModel);
            return Ok(new { token  = Success });
        }
    }
}
