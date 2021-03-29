using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage;
using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Public;
using FGW_Enterprise_Web.Application.Dtors;
using FGW_Enterprise_Web.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FGW_Enterprise_Web.Application.Catalog.ManageUser
{
    public class PublicUserRoleService: IPublicUserRoleService
    {
        private readonly SchlDBContext _context;
        public PublicUserRoleService(SchlDBContext context)
        {
            _context = context;
        }
      

         public async Task<PagedResult<UserRoleViewModel>>GetAllByCatgoryId(GetUserRolePagingRequest request)
        {
            var query = from rr in _context.Role
                        join ur in _context.UserRole on rr.Id equals ur.ur_RoleId
                        join us in _context.User on ur.ur_UserId equals us.Id
                        select new { us, rr, ur };

            //Filter
            
            if (request.RoleIds.Count > 0)
            {
                query = query.Where(p => request.RoleIds.Contains(p.rr.Id));
            }
            //paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserRoleViewModel()
                {
                    roleid = x.rr.Id,
                    rolename = x.rr.role_Name,
                    roledescrip = x.rr.role_Descrpition,
                    userid = x.us.Id,
                    userfullname = x.us.user_FullName

                }).ToListAsync();

            //select and projection
            var pagedResult = new PagedResult<UserRoleViewModel>()
            {
                TotalRecore = totalRow,
                Items = data
            };
            return pagedResult;
        }
    }
}
