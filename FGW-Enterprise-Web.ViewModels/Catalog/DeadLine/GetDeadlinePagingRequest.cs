using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.Catalog.DeadLine
{
    public class GetDeadlinePagingRequest : PagingRequestBase
    {
        public string deadlineCateId { get; set; }
    }
}
