using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Interfaces
{
    public interface IGenericRepository<T> where T:class
    {
        List<T> GetAll();

        T GetByEmployeeNumber(int EmployeeNumber);

        void Insert(T obj);
        void Update(T obj);
        void Delete(int EmployeeNumber);
        void Save();

        Boolean Exists(int EmployeeNumber);
    }
}
