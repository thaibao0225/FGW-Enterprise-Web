using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using FGW_Enterprise_Web.ViewModels.Catalog.DeadLine;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public class PublicDeadLineService : IPublicDeadLineService
    {
        private readonly SchlDBContext _context;
        public PublicDeadLineService(SchlDBContext context)
        {
            _context = context;
        }

        public async Task<List<DeadlineViewModel>> GetAll()
        {
            var query = from d in _context.Deadline
                        select new { d};
            var data = await query.Select(x => new DeadlineViewModel()
                           {
                               dl_Id = x.d.dl_Id,
                               dl_Name = x.d.dl_Name,
                               dl_TimeDeadline = x.d.dl_TimeDeadline,
                             
                               dl_CreateBy = x.d.dl_CreateBy,
                               dl_CreateDate = DateTime.Now,
                           }).ToListAsync();
            return data;
            
        }

        public async Task<PagedResult<DeadlineViewModel>> GetAllByCategoryId(GetDeadlinePagingRequest request)
        {
            var query = from d in _context.Deadline
                        join dr in _context.RegisterDeadline on d.dl_Id equals dr.rd_DeadlineId
                        join dic in _context.DeadlineCate on dr.rd_DeadineCate equals dic.dlCate_Id
                        join dif in _context.UserFile on d.dl_Id equals dif.file_DeadlineId
                        select new { d, dr, dic, dif };
            //2.filter
            if (!string.IsNullOrEmpty(request.DeadlineCateId))
            {
                query = query.Where(x => x.dic.dlCate_Id==request.DeadlineCateId);
            }
           
            //3.paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new DeadlineViewModel()
                {
                    dl_Id = x.d.dl_Id,
                    dl_Name = x.d.dl_Name,
                    dl_TimeDeadline = x.d.dl_TimeDeadline,
                    dl_cate = x.dic.dlCate_Name,
                    dl_CreateBy = x.d.dl_CreateBy,
                    dl_CreateDate = DateTime.Now,


                }).ToListAsync();

            //4.Select and projection
            var pagedResult = new PagedResult<DeadlineViewModel>()
            {
                TotalRecore = totalRow,

                Items = data
            };
            return pagedResult;
        }
    }
}
