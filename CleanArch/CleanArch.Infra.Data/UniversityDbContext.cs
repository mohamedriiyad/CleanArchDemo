using System;
using CleanArch.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options)
        :base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}
