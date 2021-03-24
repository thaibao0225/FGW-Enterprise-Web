using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class UserAction
    {
        public string action_Id { get; set; }
        public string action_Name { get; set; }
        public List<Permision> Permision { get; set; }
    }
}
