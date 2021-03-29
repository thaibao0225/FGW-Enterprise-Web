using FGW_Enterprise_Web.ViewModels.Catalog.DeadLine;
using FGW_Enterprise_Web.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public interface IPublicDeadLineService
    {
        Task<PagedResult<DeadlineViewModel>> GetAllByCategoryId(GetDeadlinePagingRequest request);
        Task<List<DeadlineViewModel>>GetAll();

    }
}
