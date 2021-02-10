using System.Collections.Generic;
using CleanArch.Domain;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesWithAuthors()
        {
            throw new System.NotImplementedException();
        }
    }
}
