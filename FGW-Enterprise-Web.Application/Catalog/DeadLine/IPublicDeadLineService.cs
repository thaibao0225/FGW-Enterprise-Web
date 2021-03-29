using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos;
using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Public;
using FGW_Enterprise_Web.ViewModels.Common;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public interface IPublicDeadLineService
    {
        PagedResult<DeadlineViewModel> GetAllByCategoryId(GetDeadlinePagingRequest request);
    }
}
