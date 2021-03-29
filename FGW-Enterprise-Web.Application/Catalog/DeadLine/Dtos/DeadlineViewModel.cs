using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos
{
    public class DeadlineViewModel
    {
        public string dl_Id { get; set; }

        public string dl_Name { get; set; }

        public string dl_Description { get; set; }
        public string dl_cate { get; set; }


        public DateTime dl_TimeDeadline { get; set; }

        public string dl_Status { get; set; }

        public string dl_CreateBy { get; set; }
        public int ViewCount { get; set; }

        public string dl_ModifiedBy { get; set; }

        public DateTime dl_CreateDate { get; set; }
    }
}
