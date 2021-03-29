using FGW_Enterprise_Web.ViewModels.Common;
using FGW_Enterprise_Web.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.System.Users
{
    public interface IUserService
    {
        Task<ApiResult<string>> Authencate(LoginRequest request);
        Task<ApiResult<bool>> Register(RegisterRequest request);
        Task<ApiResult<bool>> Edit(Guid id,UserUpdateRequest request);
        Task<ApiResult<bool>> SendMailGoogleSmtp(string _from,string _to,string _subject,string _body,string _gmailsend,string _gmailpassword);
        Task<ApiResult<bool>> SendMail(string _from, string _to, string _subject, string _body, SmtpClient client);
        Task<ApiResult<bool>> SendMailLocalSmtp(string _from, string _to, string _subject, string _body);


        Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);
        Task<ApiResult<bool>> Delete(Guid id);

        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);




    }
}
