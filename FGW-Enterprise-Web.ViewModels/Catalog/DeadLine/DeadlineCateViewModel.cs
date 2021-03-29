using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.DeadLine
{
    public class DeadlineCateViewModel
    {
        public string dlCate_Id { get; set; }

        public string dlCate_Name { get; set; }

        public string dlCate_Description { get; set; }

        public string dlCate_Status { get; set; }
        public string dlCate_CreateBy { get; set; }

        public DateTime dlCate_CreateDate { get; set; }
    }
}
