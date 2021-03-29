using FGW_Enterprise_Web.Application.System.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        String mailnhan = "nhuvtqgcs18612@fpt.edu.vn";
        String mailgui = "thaibao0225@gmail.com";
        String chude = "Kiểm tra email gửi đi";
        String noidung = "no";

        string smtpacount = "thaibao0225@gmail.com";
        string smtppassword = "ThaibaoQ@35";
        private readonly IUserService _userService;
        public EmailController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("{SendMail}")]
        [AllowAnonymous]

        public async Task<IActionResult> SendMailGoogleSmtp([FromBody] String mailgui, String mailnhann, String chudee, String noidungg, string smtpacountt, string smtppasswordd)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _userService.SendMailGoogleSmtp(mailgui, mailnhan, chude, noidung, smtpacount, smtppassword);
            if (!result.ISuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

       
    }
}
