using FGW_Enterprise_Web.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.System.Users
{
    public class UserService : IUserService
    {
        public Task<string> Authencate(LoginRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(RegisterRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
