using FGW_Enterprise_Web.Application.Catalog.Course;
using FGW_Enterprise_Web.ViewModels.Catalog.Course;
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
    public class CourseController : ControllerBase
    {
        private readonly IManageCourseService _manageCourseService;

        public CourseController(IManageCourseService manageCourseService)
        {
            _manageCourseService = manageCourseService;
        }

        [HttpGet("{courseId}")]
        public async Task<IActionResult> GetById([FromQuery] string courseId)
        {
            var deadline = await _manageCourseService.GetById(courseId);
            if (deadline == null)
                return BadRequest("cant not find deadline");
            return Ok(deadline);
        }
      
        [HttpPost]
        public async Task<IActionResult> CreateCourse([FromForm] CourseCreateRequest request)
        {
            var course = await _manageCourseService.Create(request);
            if (course == null)
                return BadRequest("wrong");
            var deadline = await _manageCourseService.GetById(course);

            return CreatedAtAction(nameof(GetById), new { id = course }, deadline);
        }

    }
}
