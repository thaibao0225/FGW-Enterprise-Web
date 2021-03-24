using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Entities
{
    public class Comment
    {
        public string comment_Id { get; set; }
        public string comment_Content { get; set; }

        public Guid comment_User { get; set; }
        public User UserC { get; set; }


        public DateTime comment_DateUpload { get; set; }
        public List<RegisterComment> RegisterComment { get; set; }


    }
}
