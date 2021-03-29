using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage;
using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Public;
using FGW_Enterprise_Web.Application.Dtors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.ManageUser
{
    public interface IPublicUserRoleService
    {
       public Task<PagedResult<UserRoleViewModel>> GetAllByCatgoryId(GetUserRolePagingRequest request);
    }
}
