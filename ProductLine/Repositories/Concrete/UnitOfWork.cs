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
        private readonly ICategoryRepository CategoryRepository;

        public UnitOfWork(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
        }

        public IProductRepository ProductRepo => ProductRepository;

        public ICategoryRepository CategoryRepo => CategoryRepository;
    }
}
