

namespace CleanArch.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        public ICourseRepository Courses { get;  set; }

        void Complete();
    }
}
