using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Manage
{
    public class DeadlineUpdateRequest
    {
        public int Id { get; set; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string CreateBy { set; get; }
        public DateTime CreateDate { set; get; }
        public string TimeDeadline { set; get; }
        public IFormFile File { get; set; }

    }
}
