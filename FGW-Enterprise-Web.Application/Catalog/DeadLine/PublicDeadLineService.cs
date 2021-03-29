using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos;
using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Public;
using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    class PublicDeadLineService : IPublicDeadLineService
    {
        public PagedResult<DeadlineViewModel> GetAllByCategoryId(int DeadlineCateId, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public PagedResult<DeadlineViewModel> GetAllByCategoryId(GetDeadlinePagingRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
