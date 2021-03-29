using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos;
using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Public;
using FGW_Enterprise_Web.ViewModels.Common;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public interface IPublicDeadLineService
    {
        Task<PagedResult<DeadlineViewModel>> GetAllByCategoryId(GetDeadlinePagingRequest request);
    }
}
