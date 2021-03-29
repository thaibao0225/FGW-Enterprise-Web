using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.Ultilities.Exceptions;
using FGW_Enterprise_Web.ViewModels.System.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
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



        public UserService(UserManager<User> userManager, SignInManager<User> sigInManager, RoleManager<Role> roleManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = sigInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<string> Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return null;

            var result =await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.GivenName,user.user_FirstName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Token:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(_config["Token:Issuer"],
                _config["Token:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new User()
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
                return true;
            }
            return false;
        }
    }


}
