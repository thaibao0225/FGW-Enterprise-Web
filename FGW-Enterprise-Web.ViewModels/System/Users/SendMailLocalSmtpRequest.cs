using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class SendMailLocalSmtpRequest
    {
        public string _from { set; get; }
        public string _to { set; get; }
        public string _subject { set; get; }
        public string _body { set; get; }
    }
}
