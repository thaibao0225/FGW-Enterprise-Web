using FGW_Enterprise_Web.AddminApp.Service;
using FGW_Enterprise_Web.ViewModels.System.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.AddminApp.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserApiClient _userApiClient;
        private readonly IConfiguration _configuration;

        public UserController(IUserApiClient userApiClient, IConfiguration configuration)
        {
            _userApiClient = userApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetUserPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _userApiClient.GetUserPagings(request);
            ViewBag.Keyword = keyword;
            if (TempData["result"] != null)
            {
                ViewBag.SuccessMessage = TempData["result"];
            }
            return View(data.ResultObj);
        }



        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var result = await _userApiClient.GetById(id);
            return View(result.ResultObj);
        }



        //
        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            return View(new DeleteUserRequest()
            {
                Id = id
            }); ;
        }


        [HttpPost]
        public async Task<IActionResult> Delete(DeleteUserRequest deleteRequest)
        {
            if (!ModelState.IsValid)
                return View();
            var result = await _userApiClient.Delete(deleteRequest.Id);
            if (result.ISuccessed)
            {
                TempData["result"] = "Delete successfully";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", result.Message);
            return View(deleteRequest);
        }

        //


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            var result = await _userApiClient.RegisterUser(request);
            if (result.ISuccessed)
            {
                TempData["result"] = "Create successfully"; 
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", result.Message);
            return View(request);
        }

        //

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var result =await _userApiClient.GetById(id);
            if (result.ISuccessed)
            {
                var user = result.ResultObj;
                var updateRequest = new UserUpdateRequest()
                {
                    Dob = user.DoB,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    FullName = user.FullName,
                    Id = id
                };
            return View(updateRequest);

            }
            return RedirectToAction("Error","Home");
           
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();
            var result = await _userApiClient.EditUser(request.Id,request);
            if(result.ISuccessed)
            {
                TempData["result"] = "Edit successfully";
                return RedirectToAction("Index");

            }
            ModelState.AddModelError("", result.Message);
            return View(request);
        }


        //





        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("Index", "Login");

        }

    }
}
