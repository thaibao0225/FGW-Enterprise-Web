using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos;
using FGW_Enterprise_Web.Application.Catalog.DeadLine.Dtos.Manage;
using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public class ManageDeadLineService : IManageDeadLineService
    {
        private readonly SchlDBContext _context;
        public ManageDeadLineService(SchlDBContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int deadlineId)
        {
            var deadline = await _context.Deadline.FindAsync(deadlineId);
            deadline.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(DeadlineCreateRequest request)
        {
            var deadline = new Deadline()
            {
                dl_Name = request.dl_Name,
                dl_Description = request.dl_Description,
                dl_CreateBy = request.dl_CreateBy,
                dl_CreateDate = DateTime.Now,
                dl_TimeDeadline = request.dl_TimeDeadline,
                dl_Status = request.dl_Status,
                ViewCount = 0,
                RegisterDeadline = new List<RegisterDeadline>()
                {
                    new RegisterDeadline()
                    {
                        rd_DeadlineId = request.dl_Id
                    }
                }


            };

            _context.Deadline.Add(deadline);
            return await _context.SaveChangesAsync();
        }

        public Task<int> Delete(int deadlineId)
        {
            throw new NotImplementedException();

        }

        public Task<List<DeadlineViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<DeadlineViewModel>> GetAllPaging(GetDeadlinePagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(DeadlineUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateDeadline(int deadlineId)
        {
            throw new NotImplementedException();
        }
    }
}
