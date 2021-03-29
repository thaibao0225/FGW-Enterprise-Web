using FGW_Enterprise_Web.Application.Common;
using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.Ultilities.Exceptions;
using FGW_Enterprise_Web.ViewModels.Catalog.DeadLine;
using FGW_Enterprise_Web.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.DeadLine
{
    public class ManageDeadLineService : IManageDeadLineService
    {
        private readonly SchlDBContext _context;
        private readonly IStorageService _storageService;
        public ManageDeadLineService(SchlDBContext context, IStorageService storageService)
        {
            _context = context;
            _storageService = storageService;
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
                dl_CreateDate =DateTime.Now,
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
            //save image
            if(request.ThumbnailFile != null)
            {
                var thumbnailFile = await _context.UserFile.FirstOrDefaultAsync(i => i.IsDefault == true && i.file_DeadlineId == request.dl_Id);
                if(thumbnailFile != null)
                {
                    thumbnailFile.file_Description = "File--";
                    thumbnailFile.file_size = request.ThumbnailFile.Length;//update when have one
                    thumbnailFile.file_url = await this.SaveFile(request.ThumbnailFile);
                    _context.UserFile.Update(thumbnailFile);
                }
                
            }
            _context.Deadline.Add(deadline);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(string deadlineId)
        {
            var deadline = await _context.Deadline.FindAsync(deadlineId);
            if (deadline == null) throw new FwgException($"Can not find a deadline:{deadlineId}");
            var files = _context.UserFile.Where(i =>i.file_DeadlineId == deadlineId);
            foreach(var file in files)
            {
                await _storageService.DeleteFileAsync(file.file_url);
            }
            
            _context.Deadline.Remove(deadline);
            

            return await _context.SaveChangesAsync();


        }

     
        public async Task<PagedResult<DeadlineViewModel>> GetAllPaging(GetMangeDeadlinePagingRequest request)
        {
            //1.join
            var query = from d in _context.Deadline
                        join dr in _context.RegisterDeadline on d.dl_Id equals dr.rd_DeadlineId
                        join dic in _context.DeadlineCate on dr.rd_DeadineCate equals dic.dlCate_Id
                        join dif in _context.UserFile on d.dl_Id equals dif.file_DeadlineId
                        select new {d,dr,dic,dif};
            //2.filter
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.d.dl_Name.Contains(request.Keyword));
            }
            if(request.DeadlineCateId.Count > 0)
            {
                query = query.Where(p => p.dr.rd_DeadlineId.Contains(request.Keyword));
            }
            //3.paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x=> new DeadlineViewModel()
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

      
        public async Task<int> Update(DeadlineUpdateRequest request)
        {
            var deadline = await _context.Deadline.FindAsync(request.Id);
            var registerDeadline = await _context.RegisterDeadline.FirstOrDefaultAsync(x => x.rd_DeadlineId == request.Id && x.rd_DeadineCate == request.deadlineCateid);
            if(deadline==null || registerDeadline == null) throw new FwgException($"Can not find a deadline:{request.Id}");
            deadline.dl_Name = request.Name;
            deadline.dl_Description = request.Description;
            deadline.dl_TimeDeadline = request.TimeDeadline;
            deadline.dl_Status = request.Status;
            deadline.dl_CreateBy = request.CreateBy;
            deadline.dl_CreateDate = DateTime.Now;
            return await _context.SaveChangesAsync();
        }

        
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }

        /// <summary>
        /// ////////////////////////
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="status"></param>
        /// <param name="isDefault"></param>
        /// <returns></returns>
        public Task<int> UpdateFile(string fileId, string status, bool isDefault)
        {
            throw new NotImplementedException();
        }

        Task<string> IManageDeadLineService.Delete(string deadlineId)
        {
            throw new NotImplementedException();
        }

        public Task<List<DeadlineViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> AddFile(string deadlineId, List<IFormFile> files)
        {
            throw new NotImplementedException();
        }

        public Task<List<DeadlineViewModel>> GetListFile(string deadlineId)
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveFile(string fileId)
        {
            throw new NotImplementedException();
        }


    }
}
