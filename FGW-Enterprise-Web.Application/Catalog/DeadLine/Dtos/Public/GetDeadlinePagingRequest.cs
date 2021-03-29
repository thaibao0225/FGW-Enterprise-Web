using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Public
{
    public class GetDeadlinePagingRequest: PagingRequestBase
    {
        public string DeadlineCateId { get; set; }
    }
}
