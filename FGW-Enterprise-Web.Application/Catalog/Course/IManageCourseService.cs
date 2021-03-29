using FGW_Enterprise_Web.ViewModels.Catalog.Course;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FGW_Enterprise_Web.Application.Catalog.Course
{
    public interface IManageCourseService
    {
        Task<string> Create(CourseCreateRequest request);
        Task<CourseViewModel> GetById(string deadlineId);

    }
}
