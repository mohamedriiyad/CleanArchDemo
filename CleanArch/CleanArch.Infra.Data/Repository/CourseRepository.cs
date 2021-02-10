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


        public Course Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Add(Course course)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new System.NotImplementedException();
        }
    }
}
