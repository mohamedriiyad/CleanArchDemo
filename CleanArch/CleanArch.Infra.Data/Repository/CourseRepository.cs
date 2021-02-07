using System.Collections.Generic;
using CleanArch.Domain;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository :ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
