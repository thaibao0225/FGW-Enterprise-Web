using FGW_Enterprise_Web.Application.Dtors;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Public
{
    public class GetUserRolePagingRequest : PagingRequesBase
    {
        public string Keyword { get; set; }
        public List<Guid> RoleIds { get; set; }
        public List<Guid> UserIds { get; set; }


    }
}
