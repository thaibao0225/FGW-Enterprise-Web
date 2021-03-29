using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.ProductFiles
{
    public class DeadlineFileUpdateRequest
    {
        public string file_Name { get; set; }

        public bool IsDefault { get; set; }
        public string file_Description { get; set; }

        public string file_url { get; set; }
        public string file_DeadlineId { get; set; }
        public string file_IsSelected { get; set; }

        public DateTime file_DateUpload { get; set; }
        public string file_CreateBy { get; set; }
        public DateTime file_CreateDate { get; set; }
        public long file_size { get; set; }





        public IFormFile file_file { get; set; }
    }
}