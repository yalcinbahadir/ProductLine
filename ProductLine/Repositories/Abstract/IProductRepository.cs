using ProductLine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetByRefNumber(string refNumber);
        IEnumerable<Product> GetByName(string name);
        IEnumerable<Product> GetByDescription(string description);
        IEnumerable<Product> GetByAssemblyNumber(string assemblyNumber);
        IEnumerable<Product> GetByCategory(string category);
    }
}
