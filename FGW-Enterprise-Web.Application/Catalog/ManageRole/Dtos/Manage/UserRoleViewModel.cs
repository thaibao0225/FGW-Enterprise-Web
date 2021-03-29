using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.ManageRole.Dtos.Manage
{
    public class UserRoleViewModel
    {
        public Guid roleid { set; get; }
        public string roledescrip { get; set; }
        public string rolename { get; set; }
        public Guid userid { set; get; }
        public string userfullname { get; set; }


    }
}
