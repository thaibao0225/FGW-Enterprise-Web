﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Deadline
    {
        public string dl_Id { get; set; }

        public string dl_Name { get; set; }

        public string dl_Description { get; set; }

        public DateTime dl_TimeDeadline { get; set; }

        public string dl_Status { get; set; }

        public string dl_CreateBy { get; set; }
        public int ViewCount { get; set; }

        public string dl_ModifiedBy { get; set; }

        public DateTime dl_CreateDate { get; set; }
        public List<RegisterDeadline> RegisterDeadline { get; set; }
        public List<UserFile> UserFileD { get; set; }





    }
}
