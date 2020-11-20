using Microsoft.EntityFrameworkCore;
using project2.Interfaces;
using project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project2.Services
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private project2Context _Context;
        private DbSet<T> table;

        public GenericRepository(project2Context Context)
        {
            _Context = Context;
            table = _Context.Set<T>();

        }
        Boolean IGenericRepository<T>.Exists(int EmployeeNumber)
        {
            Boolean _bool;
            if (table.Find(EmployeeNumber) != null)
            {
                _bool = true;
            }
            else
            {
                _bool = false;
            }

            return _bool;
        }
        void IGenericRepository<T>.Delete(int EmployeeNumber)
        {
            var employee = table.Find(EmployeeNumber);
            table.Remove(employee);
        }

        List<T> IGenericRepository<T>.GetAll()
        {
            return table.ToList();
        }

        T IGenericRepository<T>.GetByEmployeeNumber(int EmployeeNumber)
        {
            return table.Find(EmployeeNumber);
        }

        void IGenericRepository<T>.Insert(T obj)
        {
            table.Add(obj);
        }

        void IGenericRepository<T>.Update(T obj)
        {
            table.Attach(obj);
            _Context.Entry(obj).State = EntityState.Modified;
            _Context.SaveChanges();
            
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

    }
}
