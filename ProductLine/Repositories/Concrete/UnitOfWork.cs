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
        private readonly IPhotoRepository PhotoRepository;

        public UnitOfWork(IProductRepository productRepository, 
                            ICategoryRepository categoryRepository, 
                            IPhotoRepository photoRepository)
        {
            ProductRepository = productRepository;
            CategoryRepository = categoryRepository;
            PhotoRepository = photoRepository;
        }

        public IProductRepository ProductRepo => ProductRepository;

        public ICategoryRepository CategoryRepo => CategoryRepository;
        public IPhotoRepository PhotoRepo => PhotoRepository;
    }
}
