using FGW_Enterprise_Web.ViewModels.Common;
using FGW_Enterprise_Web.ViewModels.System.Users;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.AddminApp.Service
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<ApiResult<PagedResult<UserVm>>> GetUserPagings(GetUserPagingRequest request);
        Task<ApiResult<bool>> RegisterUser(RegisterRequest request);
        Task<ApiResult<bool>> EditUser(Guid id,UserUpdateRequest request);
        Task<ApiResult<UserVm>> GetById(Guid id);
        Task<ApiResult<bool>> Delete(Guid id);
        Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request);
        Task<ApiResult<bool>> SendMailGoogleSmtp(string _from, string _to, string _subject, string _body, string _gmailsend, string _gmailpassword);
        Task<ApiResult<bool>> SendMail(string _from, string _to, string _subject, string _body, SmtpClient client);
        Task<ApiResult<bool>> SendMailLocalSmtp(string _from, string _to, string _subject, string _body);



    }
}
