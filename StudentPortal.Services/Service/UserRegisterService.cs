using AutoMapper;
using Microsoft.AspNetCore.Identity;
using StudentPortal.Model.GenericRepository.IRepository;
using StudentPortal.Model.Models;
using StudentPortal.Services.IService;
using StudentPortal.Services.ViewModels;
using System;
using System.Threading.Tasks;

namespace StudentPortal.Services.Service
{
    public class UserRegisterService : IUserRegisterService
    {
        private readonly IMapper _mapper;
        private IEFRepository<Users> _iEFRepository;
        private IEFRepositoryReadOnly<Users> _iEFRepositoryReadOnly;
        private readonly UserManager<IdentityUser> _userManager;

        public UserRegisterService(IMapper mapper, IEFRepository<Users> iEFRepository, IEFRepositoryReadOnly<Users> eFRepositoryReadOnly, UserManager<IdentityUser> userManager)
        {
            _mapper = mapper;
            this._iEFRepository = iEFRepository;
            this._iEFRepositoryReadOnly = eFRepositoryReadOnly;
            _userManager = userManager;
        }
        public async Task<bool> Insert(RegisterVM UserVM)
        {
            var userEmail = await _userManager.FindByEmailAsync(UserVM.Email);
             var UserName = await _userManager.FindByNameAsync(UserVM.Username);

            if (userEmail == null && UserName == null)
            {
                IdentityUser user = new IdentityUser()
                {
                    UserName = UserVM.Username,
                    Email = UserVM.Email,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                var result = await _userManager.CreateAsync(user, UserVM.Password);
                return result.Succeeded;
            }
            else
            {
                return false;
            }
        }
    }
}
