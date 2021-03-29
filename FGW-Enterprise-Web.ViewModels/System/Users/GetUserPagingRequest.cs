using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class GetUserPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
