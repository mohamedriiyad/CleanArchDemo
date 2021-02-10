using System.Collections.Generic;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        Course Get(int id);
        IEnumerable<Course> GetAll();
        void Add(Course course);
        void Delete(int id);
        void Update(Course course);
    }
}
