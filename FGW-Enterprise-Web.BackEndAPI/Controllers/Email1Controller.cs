using FGW_Enterprise_Web.Application.System.Users;
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
    public class Email1Controller : ControllerBase
    {
        private readonly IUserService _userService;

        public Email1Controller(IUserService userService)
        {
            _userService = userService;
            
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           String _mailnhan = "nhuvtqgcs18612@fpt.edu.vn";
       String _mailgui = "thaibao0225@gmail.com";
        String _chude = "Kiểm tra email gửi đi";
       String _noidung = "havue";

        string _smtpacount = "thaibao0225@gmail.com";
        string _smtppassword = "ThaibaoQ@35";
        
        

        var result = await _userService.SendMailGoogleSmtp(_mailgui, _mailnhan, _chude, _noidung, _smtpacount, _smtppassword);

            return Ok(result);
        }
    }
}
