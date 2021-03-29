using FGW_Enterprise_Web.ViewModels.Catalog.DeadLine;
using FGW_Enterprise_Web.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public interface IManageDeadLineService
    {
        Task<int> Create(DeadlineCreateRequest request);

        Task<int> Update(DeadlineUpdateRequest request);
        Task<string> Delete(string deadlineId);
       // Task<bool> UpdateStock(int deadlineId);
        Task AddViewCount(int deadlineId);

        Task<List<DeadlineViewModel>> GetAll();
        Task<PagedResult<DeadlineViewModel>> GetAllPaging(GetMangeDeadlinePagingRequest request);

        Task<int> AddFile(string deadlineId, List<IFormFile> files );
        Task<int> RemoveFile(string fileId);
        Task<int> UpdateFile(string fileId, string status, bool isDefault);
        Task<List<DeadlineViewModel>> GetListFile(string deadlineId);




    }
}