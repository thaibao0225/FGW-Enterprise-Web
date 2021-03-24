using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class DeadlineUserFile
    {
        public string file_Id { get; set; }
        public UserFile UserFile { get; set; }
        public string dl_Id { get; set; }
        public Deadline Deadline { get; set; }



    }
}
