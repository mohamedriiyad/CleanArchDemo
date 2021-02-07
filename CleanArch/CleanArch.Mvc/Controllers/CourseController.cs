using Microsoft.AspNetCore.Mvc;
using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace CleanArch.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService; 
        }

        public IActionResult Index()
        {
            var model = _courseService.GetCourses();
            return View(model);
        }
    }
}
