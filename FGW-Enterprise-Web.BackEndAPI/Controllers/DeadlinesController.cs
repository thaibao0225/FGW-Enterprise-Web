using FGW_Enterprise_Web.Application.Catalog.DeadLine;
using FGW_Enterprise_Web.ViewModels.Catalog.DeadLine;
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
    public class DeadlinesController : ControllerBase
    {
        private readonly IPublicDeadLineService _publicDeadLineService;
        private readonly IManageDeadLineService _manageDeadLineService;


        public DeadlinesController(IPublicDeadLineService publicDeadLineService
            , IManageDeadLineService manageDeadLineService)
        {
            _manageDeadLineService = manageDeadLineService;
            _publicDeadLineService = publicDeadLineService;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAllPaging([FromQuery] GetDeadlinePagingRequest request)
        //{
        //    var deadline = await _publicDeadLineService.GetAllByCategoryId(request);
        //    return Ok(deadline);
        //}
       

       
        //[HttpGet("{deadlineCateId}")]
        //public async Task<IActionResult> GetByIdDlCatee([FromQuery] string deadlineCateId)
        //{
        //    var deadlineCate = await _manageDeadLineService.GetByIdDlCate(deadlineCateId);
        //    if (deadlineCate == null)
        //        return BadRequest("cant not find deadlinecate");
        //    return Ok(deadlineCateId);
        //}

        [HttpGet("{deadlineId}")]
        public async Task<IActionResult> GetById([FromQuery] string deadlineId)
        {
            var deadline = await _manageDeadLineService.GetById(deadlineId);
            if (deadline == null)
                return BadRequest("cant not find deadline");
            return Ok(deadline);


        }
       
        [HttpPost]
        public async Task<IActionResult> Create([FromForm] DeadlineCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var deadlineId = await _manageDeadLineService.Create(request);
            if (deadlineId == null)
                return BadRequest("wrong");
            var deadline = await _manageDeadLineService.GetById(deadlineId);

            return CreatedAtAction(nameof(GetById), new { id = deadlineId }, deadline);
        }


        //[HttpPost("cate")]
        //public async Task<IActionResult> CreateCate([FromForm] DeadlineCateCreateRequest request)
        //{
        //    var deadlineCateId = await _manageDeadLineService.CreateDlCate(request);
        //    if (deadlineCateId == null)
        //        return BadRequest("wrongg");
        //    var deadlineCate = await _manageDeadLineService.GetByIdDlCate(deadlineCateId);

        //    return CreatedAtAction(nameof(GetByIdDlCatee), new { id = deadlineCateId }, deadlineCate);
        //}



        //[HttpPut("Update-Product")]
        //public async Task<IActionResult> Update([FromBody] DeadlineUpdateRequest request)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    var affectedResult = await _manageDeadLineService.Update(request);
        //    if (affectedResult ==0)
        //        return BadRequest();
        //    return Ok();
        //}
        //[HttpPut]
        //public async Task<IActionResult> Update([FromBody] DeadlineUpdateRequest request)
        //{
        //    var affectedResult = await _manageDeadLineService.Update(request);
        //    if (affectedResult == 0)
        //        return BadRequest();
        //    return Ok();
        //}



        [HttpDelete("{deadlineId}")]
        public async Task<IActionResult> Delete([FromBody] string deadlineId)
        {
            var affectedResult = await _manageDeadLineService.Delete(deadlineId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }

    }
}
