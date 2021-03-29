using FGW_Enterprise_Web.Data.EF;
using FGW_Enterprise_Web.Data.Entities;
using FGW_Enterprise_Web.ViewModels.Catalog.Course;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.Course
{
    

    public class ManageCourseService: IManageCourseService
    {
        private readonly SchlDBContext _context;

        public ManageCourseService(SchlDBContext context)
        {
            _context = context;

        }
        public async Task<string> Create(CourseCreateRequest request)
        {
            var course = new Courses()
            {
                course_Id = request.id,
                course_Name = request.Name,
                course_Descrition = request.Descrition,
            };
           
            _context.Course.Add(course);
            await _context.SaveChangesAsync();
            return course.course_Name;
        }

        public async Task<CourseViewModel> GetById(string courseId)
        {
            var course = await _context.Course.FindAsync(courseId);
            var courseViewModel= new CourseViewModel()
            {
                id = course.course_Id,
                Name = course.course_Name,
                Descrition = course.course_Descrition,
            

            };
            return courseViewModel;
        }

        
    }
}
