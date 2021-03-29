using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.DeadLine
{
    public class DeadlineFileViewModel
    {
        public string id { get; set; }
        public string fileUrl { get; set; }
        public bool isDefault { get; set; }
        public long fileSize { get; set; }

    }
}
