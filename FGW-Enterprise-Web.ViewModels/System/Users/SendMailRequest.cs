using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class SendMailRequest
    {
        public string _from { get; set; }
        public string _to { get; set; }

        public string _subject { get; set; }

        public string _body { get; set; }
        public SmtpClient client { set; get; }

    }
}
