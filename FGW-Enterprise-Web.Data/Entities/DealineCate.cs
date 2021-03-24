using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class DeadlineCate
    {
        public string dlCate_Id { get; set; }
        public string dlCate_Name { get; set; }

        public string dlCate_Description { get; set; }

        public string dlCate_Status { get; set; }

        public string dlCate_CreateBy { get; set; }

        public string dlCate_ModifiedBy { get; set; }

        public DateTime dlCate_CreateDate { get; set; }
        public List<RegisterEvent> RegisterEvent { get; set; }
        public List<RegisterDeadline> RegisterDeadline { get; set; }



    }
}
