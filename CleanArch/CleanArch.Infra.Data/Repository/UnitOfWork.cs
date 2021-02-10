using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UniversityDbContext _context;
        public ICourseRepository Courses { get; private set; }

        public UnitOfWork(UniversityDbContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}
