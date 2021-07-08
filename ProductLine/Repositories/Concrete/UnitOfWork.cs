using ProductLine.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductLine.Repositories.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IProductRepository ProductRepository;

        public UnitOfWork(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public IProductRepository ProductRepo => ProductRepository;
    }
}
