using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.Email
{
    public class GetEmailRequest
    {
        public String _mailnhan { get; set; }
        public String _mailgui { get; set; }
        public String _chude { get; set; }

        public String _noidung { get; set; }
        public string _smtpacount { get; set; }

        public string _smtppassword { get; set; }


    }
}
