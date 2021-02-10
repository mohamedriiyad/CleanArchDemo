using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Interfaces
{
    public interface IRepository <T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T model);
        void Delete(int id);
        void Update(T model);
    }
}
