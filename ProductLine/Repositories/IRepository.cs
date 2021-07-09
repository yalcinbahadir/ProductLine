using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(T entity);
        bool Delete(int id);
        T Update(T entity);
        bool SaveChanges();
    }
}
