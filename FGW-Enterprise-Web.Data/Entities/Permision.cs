using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Permision
    {
        public string per_ActionId { get; set; }
        public UserAction UserAction { get; set; }
        public string per_FunctionId { get; set; }
        public Function Function { get; set; }
        public string per_RoleId { get; set; }
        public Role Role { get; set; }
    }
}
