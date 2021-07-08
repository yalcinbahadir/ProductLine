using ProductLine.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepo { get; }
    }
}
