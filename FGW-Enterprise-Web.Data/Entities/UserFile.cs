using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class UserFile
    {
        public string file_Id { get; set; }
        public string file_Name { get; set; }
        public string file_Description { get; set; }
        public string file_file { get; set; }
        public string file_url { get; set; }
        public long file_size { get; set; }

        public string file_DeadlineId { get; set; }
        public Deadline DeadlineInUserFile { get; set; }
        public bool IsDefault { get; set; }

        public string file_IsSelected { get; set; }
        public DateTime file_DateUpload { get; set; }
        public DateTime file_CreateBy { get; set; }
        public DateTime file_CreateDate { get; set; }
        public List<RegisterComment> RegisterComment { get; set; }




    }
}
