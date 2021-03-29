using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class UserImage
    {
        public string Id { get; set; }
        public Guid UserId { get; set; }
        public string UrlImg { get; set; }
        public DateTime DateCreated { get; set; }
        public int FileSize { get; set; }
        public User UserI { get; set; }
    }
}
