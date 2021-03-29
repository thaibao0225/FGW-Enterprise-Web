using FGW_Enterprise_Web.Application.Catalog.DeadLine;
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
    public class DeadlineController : ControllerBase
    {
        private readonly IPublicDeadLineService _publicDeadLineService;

        public DeadlineController(IPublicDeadLineService publicDeadLineService)
        {
            _publicDeadLineService = publicDeadLineService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var deadline = await _publicDeadLineService.GetAll();
            return Ok(deadline);
        }
    }
}
