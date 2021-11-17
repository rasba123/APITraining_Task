using Microsoft.AspNetCore.Mvc;
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
    public class UserController: Controller
    {
        private IUserRegisterService RegUserService;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IUserRegisterService userRegisterService)
        {
            _logger = logger;
            this.RegUserService = userRegisterService;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterVM User)
        {
            string InsertVal = "";
            bool Success = await RegUserService.Insert(User);
            if (Success == true)
            {
                InsertVal = "User Registered";
            }
            else
            {
                InsertVal = "User not Registered";
            }
            return Ok(InsertVal);
        }

    }
}
