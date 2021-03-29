using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos;
using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Manage;
using FGW_Enterprise_Web.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public interface IManageDeadLineService
    {
        Task<int> Create(DeadlineCreateRequest request);

        Task<int> Update(DeadlineUpdateRequest request);
        Task<int> Delete(int deadlineId);
       // Task<bool> UpdateStock(int deadlineId);
        Task AddViewCount(int deadlineId);



        Task<List<DeadlineViewModel>> GetAll();
        Task<PagedResult<DeadlineViewModel>> GetAllPaging(GetDeadlinePagingRequest request);


    }
}