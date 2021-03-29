using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Function
    {
        public string func_Id { get; set; }
        public string func_Name { get; set; }
        public string func_ParentId { get; set; }

        public string func_Status { get; set; }
        public List<Function> FunctionsFun { get; set; }

    }
}
