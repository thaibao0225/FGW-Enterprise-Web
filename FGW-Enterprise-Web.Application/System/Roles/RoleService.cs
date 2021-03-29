using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.ViewModels.System.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<Role> _roleManager;
        public RoleService(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<List<RoleVm>> GetAll()
        {
            var role = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Decription = x.role_Descrpition
                }).ToListAsync();
            return role;
        }
    }
}
