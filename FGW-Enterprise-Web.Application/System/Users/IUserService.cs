using FGW_Enterprise_Web.ViewModels.Common;
using FGW_Enterprise_Web.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<bool>> Edit(Guid id,UserUpdateRequest request);

        
        Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);
        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);




    }
}
