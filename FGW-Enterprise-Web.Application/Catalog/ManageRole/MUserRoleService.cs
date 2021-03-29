using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage;
using FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Public;
using FGW_Enterprise_Web.Application.Dtors;
using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.Ultilities.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.ManageUser
{
    public class MUserRoleService : IMUserRoleService
    {
        private readonly SchlDBContext _context;
        public MUserRoleService(SchlDBContext context)
        {
            _context = context;
        }

        

        public async Task<int> Create(MUserRoleCreateRequest request)
        {
            var role = new Role()
            {
                role_Name = request.RoleName,
                role_Descrpition = request.RoleDescrpition, 


            };
            _context.Role.Add(role);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(string UserRoleId)
        {
            var role = await _context.Role.FindAsync(UserRoleId);
            if (role == null) throw new FwgException($"Can not find this role:{UserRoleId}");
            _context.Role.Remove(role);
            return await _context.SaveChangesAsync();
        }


        public async Task<List<UserRoleViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

     

        public async Task<PagedResult<UserRoleViewModel>> GetAllPaging(GetUserRolePagingRequest request)
        {
            //select
            var query = from rr in _context.Role
                        join ur in _context.UserRole on rr.Id equals ur.ur_RoleId
                        join us in _context.User on ur.ur_UserId equals us.Id
                        select new { us, rr,ur};

            //Filter
            if (!string.IsNullOrEmpty(request.Keyword))
                query = query.Where(x=>x.rr.role_Name.Contains(request.Keyword));

            if(request.UserIds.Count > 0)
            {
                query = query.Where(p=>request.UserIds.Contains(p.ur.ur_UserId));
            }
            //paging
            int totalRow = await query.CountAsync();
            var data =  await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserRoleViewModel()
                {
                    roleid = x.rr.Id,
                    rolename = x.rr.role_Name,
                    roledescrip = x.rr.role_Descrpition,
                    userid = x.us.Id,
                    userfullname= x.us.user_FullName
                    
                }).ToListAsync();

            //select and projection
            var pagedResult = new PagedResult<UserRoleViewModel>()
            {
                TotalRecore = totalRow,
                Items = data
            };
            return pagedResult;
        }

        public async Task<int> Update(MUserRoleUpdateRequest request)
        {
            var role = _context.Role.Find(request.RoleId);
            if (role == null) throw new FwgException($"Can not find a role with id:{request.RoleId}");
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateRoleDes(string RoleID, string RDescription, string RName)
        {
            var role =await _context.Role.FindAsync(RoleID);
            if(role==null) throw new FwgException($"Can not find a role with id:{RoleID}");
            role.Name = RName;
            role.role_Descrpition = RDescription;
            return await _context.SaveChangesAsync() > 0;
            
        }

        public Task<bool> UpdateRoleName(string RoleID, string RName)
        {
            throw new NotImplementedException();
        }
    }
}
