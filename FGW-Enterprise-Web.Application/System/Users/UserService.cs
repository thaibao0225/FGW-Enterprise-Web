﻿using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.ViewModels.Common;
using FGW_Enterprise_Web.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        private readonly SchlDBContext _context;




        public UserService(UserManager<User> userManager, 
            SignInManager<User> sigInManager, 
            RoleManager<Role> roleManager,
            SchlDBContext context,
            IConfiguration config)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = sigInManager;
            _roleManager = roleManager;
            _config = config;
        }


        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return new ApiErrorResult<string>("Account is not exist");

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.user_FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles)),
                new Claim(ClaimTypes.Name, request.UserName)

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("user is not exist");
            }
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
                return new ApiSuccessResult<bool>();
            
            return new ApiErrorResult<bool>("Failed to delete");

        }

        public async Task<ApiResult<bool>> Edit(Guid id,UserUpdateRequest request)
        {

            if (await _userManager.Users.AnyAsync(x => x.Email == request.Email && x.Id != id))
            {
                return new ApiErrorResult<bool>("Emai is already exist");
            }
            var users =await _userManager.FindByIdAsync(id.ToString());
            users.Email = request.Email;
            users.user_FirstName = request.FirstName;
            users.user_LastName = request.LastName;
            users.user_FullName = request.FullName;
            users.user_DOB = request.Dob;
            

            var result = await _userManager.UpdateAsync(users);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Update không thành công");
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<UserVm>("user khong ton tai");
            }
            var roles = await _userManager.GetRolesAsync(user);
            var userVm = new UserVm()
            {
                FirstName = user.user_FirstName,
                LastName = user.user_LastName,
                FullName = user.user_FullName,
                DoB = user.user_DOB,
                Id = user.Id,
                Email = user.Email,
                Roles = roles
            };
            return new ApiSuccessResult<UserVm>(userVm);
        }

        public async Task<ApiResult<PagedResult<UserVm>>> GetUserPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            //var queryRole = from p in _userManager.Users
            //                join pt in _con

            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                || x.Email.Contains(request.Keyword));
            }

           

            //paging

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserVm()
                {
                    FirstName = x.user_FirstName,
                    LastName = x.user_LastName,
                    Id = x.Id,
                    UserName = x.UserName,
                    Email = x.Email

                }).ToListAsync();

       
            //select and projection
            var pagedResult = new PagedResult<UserVm>()
            {
                TotalRecore = totalRow,
                PageIndex= request.PageIndex,
                PageSize = request.PageSize,
                Items = data
            };
            
            return new ApiSuccessResult<PagedResult<UserVm>>(pagedResult);
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
            {

                return new ApiErrorResult<bool>("Account have existed");
            }
            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<bool>("Email have existed");
            }
            user = new User()
            {

                Email = request.Email,
                user_FirstName = request.user_FirstName,
                user_LastName = request.user_LastName,
                user_FullName = request.user_FullName,
                user_DOB = request.user_DOB,
                UserName = request.UserName,
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();
            }
            return new ApiErrorResult<bool>("Register Failed");
        }

        public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<bool>("Tài khoản không tồn tại");
            }
            var removedRoles = request.Roles.Where(x => x.Selected == false).Select(x => x.Name).ToList();
            foreach (var roleName in removedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == true)
                {
                    await _userManager.RemoveFromRoleAsync(user, roleName);
                }
            }
            await _userManager.RemoveFromRolesAsync(user, removedRoles);

            var addedRoles = request.Roles.Where(x => x.Selected).Select(x => x.Name).ToList();
            foreach (var roleName in addedRoles)
            {
                if (await _userManager.IsInRoleAsync(user, roleName) == false)
                {
                    await _userManager.AddToRoleAsync(user, roleName);
                }
            }

            return new ApiSuccessResult<bool>();
        }

     

        public async Task<ApiResult<bool>> SendMail(string _from, string _to, string _subject, string _body, SmtpClient client)
        {
            // Tạo nội dung Email        
            MailMessage message = new MailMessage(
                from: _from,
                to: _to,
                subject: _subject,
                body: _body
            );
            message.BodyEncoding = Encoding.UTF8;
            message.SubjectEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            message.ReplyToList.Add(new MailAddress(_from));
            message.Sender = new MailAddress(_from);


            try
            {
                await client.SendMailAsync(message);
                return new ApiSuccessResult<bool>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new ApiErrorResult<bool>();
            }
        }

        public async Task<ApiResult<bool>> SendMailLocalSmtp(string _from, string _to, string _subject, string _body)
        {
            using (SmtpClient client = new SmtpClient("localhost"))
            {
                return await SendMail(_from, _to, _subject, _body, client);
            }
        }

        public async Task<ApiResult<bool>> SendMailGoogleSmtp(
        
            string _from,
            string _to,
            string _subject,
            string _body,
            string _gmailsend,
            string _gmailpassword) 
            {

                MailMessage message = new MailMessage(
                    from: _from,
                    to: _to,
                    subject: _subject,
                    body: _body
                );
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;
                message.ReplyToList.Add(new MailAddress(_from));
                message.Sender = new MailAddress(_from);

                // Tạo SmtpClient kết nối đến smtp.gmail.com
                using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                {
                    client.Port = 587;
                    client.Credentials = new NetworkCredential(_gmailsend, _gmailpassword);
                    client.EnableSsl = true;
                    return await SendMail(_from, _to, _subject, _body, client);
                }
            }
        }

        
       
    }



