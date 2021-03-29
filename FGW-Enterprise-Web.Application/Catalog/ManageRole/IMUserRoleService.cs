using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage;
using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Public;
using FGW_Enterprise_Web.Application.Dtors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.ManageUser
{
    public interface IMUserRoleService
    {
        Task<int> Create(MUserRoleCreateRequest request);

        Task<int> Update(MUserRoleUpdateRequest request);

        Task<int> Delete(string UserRoleId);
        Task<bool> UpdateRoleDes(string RoleID, string RDescription, string RName);
        Task<bool> UpdateRoleName(string RoleID, string RName);

        Task<List<UserRoleViewModel>> GetAll();
        Task<PagedResult<UserRoleViewModel>> GetAllPaging(GetUserRolePagingRequest request);

    }
}
