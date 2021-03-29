using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage
{
    public class MUserRoleUpdateRequest
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescrpition { get; set; }
    }
}
