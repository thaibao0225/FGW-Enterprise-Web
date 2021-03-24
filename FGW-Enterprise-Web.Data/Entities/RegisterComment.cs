using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class RegisterComment
    {
        public string rescmt_CmtId { get; set; }
        public Comment Comment { get; set; }
        public string rescmt_FileId { get; set; }
        public UserFile UserFile { get; set; }
    }
}
