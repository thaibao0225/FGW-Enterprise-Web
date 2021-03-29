using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RoleAssignRequest: PagingRequestBase
    {
        public Guid Id { get; set; }
        public List<SelectedItems> Roles { get; set; } = new List<SelectedItems>();
        public string Keyword { get; set; }

    }
}
