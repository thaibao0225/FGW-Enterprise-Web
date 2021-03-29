using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Manage
{
    public class GetDeadlinePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<string> DeadlineCateId { get; set; }


    }
}
