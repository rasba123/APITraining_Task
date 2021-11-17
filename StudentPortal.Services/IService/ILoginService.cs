using StudentPortal.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentPortal.Services.IService
{
    public interface ILoginService
    {
       Task<bool> Login(LoginVM Input);
        Task<bool> LogoutAsync();
    }
}
