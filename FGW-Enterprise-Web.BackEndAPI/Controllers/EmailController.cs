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
        private readonly String _mailnhan = "nhuvtqgcs18612@fpt.edu.vn";
        private readonly String _mailgui = "thaibao0225@gmail.com";
        private readonly String _chude = "Kiểm tra email gửi đi";
        private readonly String _noidung = "have";

        private readonly string _smtpacount = "thaibao0225@gmail.com";
        private readonly string _smtppassword = "ThaibaoQ@35";
        private readonly IUserService _userService;
        public EmailController(IUserService userService, String mailnhan, String mailgui, String chude, String noidung, string smtpacount, string smtppassword)
        {
            _userService = userService;
            _mailnhan = mailnhan;
            _mailgui = mailgui;
            _chude = chude;
            _noidung = noidung;
            _smtpacount = smtpacount;
            _smtppassword = smtppassword;
        }
        [HttpGet("{SendMail}")]
        public async Task<IActionResult> SendMail()
        {
          
            
            //var result = await _userService.SendMailGoogleSmtp(_mailgui, _mailnhan, _chude, _noidung, _smtpacount, _smtppassword);
            
            return Ok("ok");
        }

       
    }
}
