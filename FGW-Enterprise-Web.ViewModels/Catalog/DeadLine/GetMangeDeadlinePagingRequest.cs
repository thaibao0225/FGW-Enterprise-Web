using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.DeadLine
{
    public class GetMangeDeadlinePagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<string> DeadlineCateId { get; set; }

    }
}
